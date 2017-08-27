using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;
using Microsoft.AspNetCore.Authorization;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using WebApplication.Identity;
using WebApplication.Infrastructure;
using WebApplication.Infrastructure.ViewModels;
using WebApplication.Infrastructure.Extensions;
using WebApplication.Core.Domains;

namespace WebApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
     public class UsersController : BaseController
    {
        private readonly ILogger _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        protected readonly RoleStore<IdentityUser, IdentityRole> _roleStore;
        public UsersController(
            UserManager<IdentityUser> userManager,
            ILoggerFactory loggerFactory,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context,
            UserStore<IdentityUser,IdentityRole> userStore
          
            ) : base(userManager,context, userStore)
        {
            _roleManager = roleManager;
            _logger = loggerFactory.CreateLogger<UsersController>();

   
        }


        public async Task<IActionResult> Index(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? page
            )
        {

            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";


            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            
          
            var u = _userManager.Users.ToList().ToListUserAdminViewModel();

            var users = from m in u
                         select m;

                        
            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.UserName.Contains(searchString)
                                       || s.Email.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    users = users.OrderByDescending(s => s.UserName);
                    break;
                case "Date":
                    users = users.OrderBy(s => s.CreatedOn);
                    break;
                case "date_desc":
                    users = users.OrderByDescending(s => s.CreatedOn);
                    break;
                default:
                    users = users.OrderBy(s => s.UserName);
                    break;
            }

            int pageSize = 3;
            return View(await PaginatedList<UserAdminViewModel>.CreateAsync(users.ToList(), page ?? 1, pageSize));

        }


        public async Task<IActionResult> Details(string id)
        {
     
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);          
        }
        
        public async Task<IActionResult> Edit(string id)
        {
           
            if (id == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            ViewBag.Roles = _roleManager.Roles.ToList().ToListViewModel();

            return View(user.ToViewModel());
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UserViewModel model)
        {

            if (ModelState.IsValid)
            {                 
                var user = await _userManager.FindByIdAsync(model.Id);

                if (user == null)
                {
                    return NotFound();
                }

                var role = _userManager.GetRolesAsync(user).Result;

                await _userManager.RemoveFromRolesAsync(user, role);

                await _userManager.AddToRolesAsync(user,model.RoleNames);
                
                await _userManager.SetEmailAsync(user, model.Email);
                await _userManager.SetUserNameAsync(user, model.UserName);

                
                //user = model.UpdateEntity(user);

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    AddErrors(result);
                }
            }

            ViewBag.Roles = _roleManager.Roles.ToList().ToListViewModel();

            return View(model);
        }

        public async Task<IActionResult> ChangePassword(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(UserChangePasswordViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.Id);

                if (user == null)
                {
                    return NotFound();
                }

                await _userManager.RemovePasswordAsync(user);
                await _userManager.AddPasswordAsync(user, model.Password);

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    AddErrors(result);
                }
            }

            return View(model);
        }

        [ActionName("Delete")]
        public async Task<IActionResult> Delete(string id)
        {
          
            if (id == null)
            {
                return NotFound();
            }

            IdentityUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            await _userManager.DeleteAsync(user);

            return RedirectToAction("Index");
        }


        public IActionResult Create()
        {
           
            ViewBag.Roles = _roleManager.Roles.ToList().ToListViewModel();

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserViewModel model)
        {

           if (ModelState.IsValid)
           {
               var user = model.ToEntity();

               var result = await _userManager.CreateAsync(user, model.Password);

               var roles = await _userManager.AddToRolesAsync(user, model.RoleNames);

               if (result.Succeeded)
               {
                   return RedirectToAction("Index");
               }
               else
               {
                   AddErrors(result);
               }
           }

           ViewBag.Roles = _roleManager.Roles.ToList().ToListViewModel();

           return View(model);
        }
            
  
        }

    }

    
  
