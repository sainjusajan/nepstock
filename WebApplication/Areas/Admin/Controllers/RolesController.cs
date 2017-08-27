﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Identity;
using WebApplication.Infrastructure;
using WebApplication.Infrastructure.Extensions;
using WebApplication.Infrastructure.ViewModels;

namespace WebApplication.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]

    public class RolesController : BaseController
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger _logger;
     
        public RolesController(
           UserManager<IdentityUser> userManager,         
           RoleManager<IdentityRole> roleManager,
           ILoggerFactory loggerFactory,
           ApplicationDbContext context,
           UserStore<IdentityUser, IdentityRole> users) :
           base(userManager, context,users)
        {
            _roleManager = roleManager;
            _logger = loggerFactory.CreateLogger<RolesController>();
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles;

            return View(roles.ToList().ToListViewModel());
        }

        public IActionResult Create()
        {
            return View();
        }
 
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                return NotFound();
            }

            return View(role);
        }

  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RoleViewModel model)
        {

            if (ModelState.IsValid)
            {
                var role = model.ToEntity();

                var result = await _roleManager.CreateAsync(role);

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

            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                return NotFound();
            }

            return View(role);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            
            var role = await _roleManager.FindByIdAsync(id);

            await _roleManager.DeleteAsync(role);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(string id)
        {
        
            if (id == null)
            {
                return NotFound();
            }

            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                return NotFound();
            }

                return View(role.ToViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(RoleViewModel model)
        {
           
            var role = await _roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                role = model.UpdateEntity(role);

                var result = await _roleManager.UpdateAsync(role);

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

    }
}
