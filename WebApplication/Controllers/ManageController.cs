using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Identity;
using WebApplication.Infrastructure.Interface.Services;
using WebApplication.Infrastructure.ViewModels.ManageViewModels;
using WebApplication.Infrastructure.ViewModels.ProfileViewModels;

namespace WebApplication.Controllers
{
    public class ManageController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        IdentityUser currentUser;

        public ManageController(
        UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager,
        IEmailSender emailSender,
        ISmsSender smsSender,
        ILoggerFactory loggerFactory,
        IMapper mapper
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _smsSender = smsSender;
            _logger = loggerFactory.CreateLogger<ManageController>();
            _mapper = mapper;
        }

        //
        // GET: /Manage/Index
        [HttpGet]
        public async Task<IActionResult> Index(ManageMessageId? message = null)
        {
            ViewData["StatusMessage"] =
                message == ManageMessageId.ChangePasswordSuccess ? "Your password has been changed."
                : message == ManageMessageId.SetPasswordSuccess ? "Your password has been set."
                : message == ManageMessageId.SetTwoFactorSuccess ? "Your two-factor authentication provider has been set."
                : message == ManageMessageId.Error ? "An error has occurred."
                : message == ManageMessageId.AddPhoneSuccess ? "Your phone number was added."
                : message == ManageMessageId.RemovePhoneSuccess ? "Your phone number was removed."
                : "";

            var user = await GetCurrentUserAsync();
            var model = new IndexViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                BirthCountry = user.BirthCountry,
                CurrentCountry = user.CurrentCountry,
                DateOfBirth = user.DateOfBirth,
                HasPassword = await _userManager.HasPasswordAsync(user),
                PhoneNumber = await _userManager.GetPhoneNumberAsync(user),
                TwoFactor = await _userManager.GetTwoFactorEnabledAsync(user),
                Logins = await _userManager.GetLoginsAsync(user),
                BrowserRemembered = await _signInManager.IsTwoFactorClientRememberedAsync(user)
            };
            return View(model);
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}


        //
        // POST: /Manage/RemoveLogin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveLogin(RemoveLoginViewModel account)
        {
            ManageMessageId? message = ManageMessageId.Error;
            var user = await GetCurrentUserAsync();
            if (user != null)
            {
                var result = await _userManager.RemoveLoginAsync(user, account.LoginProvider, account.ProviderKey);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    message = ManageMessageId.RemoveLoginSuccess;
                }
            }
            return RedirectToAction(nameof(ManageLogins), new { Message = message });
        }

        ////
        // GET: /Manage/AddPhoneNumber
        public IActionResult AddPhoneNumber()
        {
            return View();
        }

        //
        // POST: /Manage/AddPhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPhoneNumber(AddPhoneNumberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            // Generate the token and send it
            var user = await GetCurrentUserAsync();
            var code = await _userManager.GenerateChangePhoneNumberTokenAsync(user, model.PhoneNumber);
            await _smsSender.SendSmsAsync(model.PhoneNumber, "Your security code is: " + code);
            return RedirectToAction(nameof(VerifyPhoneNumber), new { PhoneNumber = model.PhoneNumber });
        }

        //
        // POST: /Manage/EnableTwoFactorAuthentication
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EnableTwoFactorAuthentication()
        {
            var user = await GetCurrentUserAsync();
            if (user != null)
            {
                await _userManager.SetTwoFactorEnabledAsync(user, true);
                await _signInManager.SignInAsync(user, isPersistent: false);
                _logger.LogInformation(1, "User enabled two-factor authentication.");
            }
            return RedirectToAction(nameof(Index), "Manage");
        }

        //
        // POST: /Manage/DisableTwoFactorAuthentication
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DisableTwoFactorAuthentication()
        {
            var user = await GetCurrentUserAsync();
            if (user != null)
            {
                await _userManager.SetTwoFactorEnabledAsync(user, false);
                await _signInManager.SignInAsync(user, isPersistent: false);
                _logger.LogInformation(2, "User disabled two-factor authentication.");
            }
            return RedirectToAction(nameof(Index), "Manage");
        }

        //
        // GET: /Manage/VerifyPhoneNumber
        [HttpGet]
        public async Task<IActionResult> VerifyPhoneNumber(string phoneNumber)
        {
            var code = await _userManager.GenerateChangePhoneNumberTokenAsync(await GetCurrentUserAsync(), phoneNumber);
            // Send an SMS to verify the phone number
            return phoneNumber == null ? View("Error") : View(new VerifyPhoneNumberViewModel { PhoneNumber = phoneNumber });
        }

        //
        // POST: /Manage/VerifyPhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VerifyPhoneNumber(VerifyPhoneNumberViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await GetCurrentUserAsync();
            if (user != null)
            {
                var result = await _userManager.ChangePhoneNumberAsync(user, model.PhoneNumber, model.Code);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction(nameof(Index), new { Message = ManageMessageId.AddPhoneSuccess });
                }
            }
            // If we got this far, something failed, redisplay the form
            ModelState.AddModelError(string.Empty, "Failed to verify phone number");
            return View(model);
        }

        //
        // GET: /Manage/RemovePhoneNumber
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemovePhoneNumber()
        {
            var user = await GetCurrentUserAsync();
            if (user != null)
            {
                var result = await _userManager.SetPhoneNumberAsync(user, null);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction(nameof(Index), new { Message = ManageMessageId.RemovePhoneSuccess });
                }
            }
            return RedirectToAction(nameof(Index), new { Message = ManageMessageId.Error });
        }

        //
        // GET: /Manage/ChangePassword
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST: /Manage/ChangePassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await GetCurrentUserAsync();
            if (user != null)
            {
                var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

                if (result.Succeeded)
                {
                    await _emailSender.SendEmailAsync(user.Email.ToString(), "Password Changed",
                      "Your password has changed");


                    await _signInManager.SignInAsync(user, isPersistent: false);
                    _logger.LogInformation(3, "User changed their password successfully.");
                    return RedirectToAction(nameof(Index), new { Message = ManageMessageId.ChangePasswordSuccess });
                }
                AddErrors(result);
                return View(model);
            }
            return RedirectToAction(nameof(Index), new { Message = ManageMessageId.Error });
        }

        //
        // GET: /Manage/SetPassword
        [HttpGet]
        public IActionResult SetPassword()
        {
            return View();
        }

        //
        // POST: /Manage/SetPassword
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SetPassword(SetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await GetCurrentUserAsync();
            if (user != null)
            {
                var result = await _userManager.AddPasswordAsync(user, model.NewPassword);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction(nameof(Index), new { Message = ManageMessageId.SetPasswordSuccess });
                }
                AddErrors(result);
                return View(model);
            }
            return RedirectToAction(nameof(Index), new { Message = ManageMessageId.Error });
        }

        //GET: /Manage/ManageLogins
        [HttpGet]
        public async Task<IActionResult> ManageLogins(ManageMessageId? message = null)
        {
            ViewData["StatusMessage"] =
                message == ManageMessageId.RemoveLoginSuccess ? "The external login was removed."
                : message == ManageMessageId.AddLoginSuccess ? "The external login was added."
                : message == ManageMessageId.Error ? "An error has occurred."
                : "";
            var user = await GetCurrentUserAsync();
            if (user == null)
            {
                return View("Error");
            }
            var userLogins = await _userManager.GetLoginsAsync(user);
            var otherLogins = _signInManager.GetExternalAuthenticationSchemes().Where(auth => userLogins.All(ul => auth.AuthenticationScheme != ul.LoginProvider)).ToList();
            ViewData["ShowRemoveButton"] = user.PasswordHash != null || userLogins.Count > 1;
            return View(new ManageLoginsViewModel
            {
                CurrentLogins = userLogins,
                OtherLogins = otherLogins
            });
        }

        //
        // POST: /Manage/LinkLogin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LinkLogin(string provider)
        {
            // Request a redirect to the external login provider to link a login for the current user
            var redirectUrl = Url.Action("LinkLoginCallback", "Manage");
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl, _userManager.GetUserId(User));
            return Challenge(properties, provider);
        }

        //
        // GET: /Manage/LinkLoginCallback
        [HttpGet]
        public async Task<ActionResult> LinkLoginCallback()
        {
            var user = await GetCurrentUserAsync();
            if (user == null)
            {
                return View("Error");
            }
            var info = await _signInManager.GetExternalLoginInfoAsync(await _userManager.GetUserIdAsync(user));
            if (info == null)
            {
                return RedirectToAction(nameof(ManageLogins), new { Message = ManageMessageId.Error });
            }
            var result = await _userManager.AddLoginAsync(user, info);
            var message = result.Succeeded ? ManageMessageId.AddLoginSuccess : ManageMessageId.Error;
            return RedirectToAction(nameof(ManageLogins), new { Message = message });
        }

        //[HttpGet]
        //public async Task<IActionResult> GetUserInfo()
        //{
        //    var user = await GetCurrentUserAsync();
        //    if (user == null)
        //    {
        //        return View("Error");
        //    }
        //    //var model = _mapper.Map<IdentityUser, ProfileViewModel>(user);
        //    //var model = _mapper.Map<ProfileViewModel>(user);

        //    ProfileViewModel profilevm= new ProfileViewModel
        //    {
        //         Id = user.Id,
        //         UserName = Task.FromResult(user.UserName),
        //         FirstName = user.FirstName,
        //         LastName = user.LastName,
        //         Email = Task.FromResult(user.Email),
        //         BirthCountry = user.BirthCountry,
        //         CurrentCountry = user.CurrentCountry,
        //         PhoneNumber = Task.FromResult(user.PhoneNumber),
        //         DateOfBirth = user.DateOfBirth,
        //         CreatedOn = user.CreatedOn
        //    };

        //    //return PartialView(model);

        //    //return PartialView(profilevm);

        //    //return View("_GeneralPartial", profilevm);
        //    return View("Index", profilevm);
        //    //return View(profilevm);

        //}

        #region EditGeneralProfile
        public IActionResult CancelEdit()
        {
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public async Task<IActionResult> EditUserName()
        {
            var user = await GetCurrentUserAsync();
            var model = new IndexViewModel
            {
                UserName = user.UserName
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUserName(IndexViewModel model)
        {
            var user = await GetCurrentUserAsync();
            if (user==null)
            {
                return View("Error");
            }
            if(ModelState.IsValid)
            {
                user.UserName = model.UserName;
                await _userManager.UpdateAsync(user);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> EditName()
        {
            var user = await GetCurrentUserAsync();
            var model = new IndexViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditName(IndexViewModel model)
        {
            var user = await GetCurrentUserAsync();
            if (user == null)
            {
                return View("Error");
            }
            if (ModelState.IsValid)
            {
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                await _userManager.UpdateAsync(user);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> EditBirthCountry()
        {
            var user = await GetCurrentUserAsync();
            var model = new IndexViewModel
            {
                BirthCountry = user.BirthCountry
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditBirthCountry(IndexViewModel model)
        {
            var user = await GetCurrentUserAsync();
            if (user == null)
            {
                return View("Error");
            }
            if (ModelState.IsValid)
            {
                user.BirthCountry = model.BirthCountry;
                await _userManager.UpdateAsync(user);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> EditCurrentCountry()
        {
            var user = await GetCurrentUserAsync();
            var model = new IndexViewModel
            {
                CurrentCountry = user.CurrentCountry
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditCurrentCountry(IndexViewModel model)
        {
            var user = await GetCurrentUserAsync();
            if (user == null)
            {
                return View("Error");
            }
            if (ModelState.IsValid)
            {
                user.CurrentCountry = model.CurrentCountry;
                await _userManager.UpdateAsync(user);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> EditDateOfBirth()
        {
            var user = await GetCurrentUserAsync();
            var model = new IndexViewModel
            {
                DateOfBirth = user.DateOfBirth
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditDateOfBirth(IndexViewModel model)
        {
            var user = await GetCurrentUserAsync();
            if (user == null)
            {
                return View("Error");
            }
            if (ModelState.IsValid)
            {
                user.DateOfBirth = model.DateOfBirth;
                await _userManager.UpdateAsync(user);
            }
            return RedirectToAction("Index");
        }
        #endregion EditGeneralProfile

        private async Task<IdentityUser> GetCurrentUserAsync()
        {
            return await _userManager.GetUserAsync(HttpContext.User);
        }

        #region Helpers

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        public enum ManageMessageId
        {
            AddPhoneSuccess,
            AddLoginSuccess,
            ChangePasswordSuccess,
            SetTwoFactorSuccess,
            SetPasswordSuccess,
            RemoveLoginSuccess,
            RemovePhoneSuccess,
            Error
        }

        //private Task<IdentityUser> GetCurrentUserAsync()
        //{
        //    return _userManager.GetUserAsync(HttpContext.User);
        //}

        #endregion Helpers
    }
}
