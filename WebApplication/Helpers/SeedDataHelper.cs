using Microsoft.AspNetCore.Identity;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Identity;
using WebApplication.Infrastructure;

namespace WebApplication.Helpers
{
    public class SeedDataHelper
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedDataHelper(ApplicationDbContext context,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context; 
            _userManager = userManager;
            _roleManager = roleManager;

        }
        
        public async void Initialize()
        {
            var user = new IdentityUser
            {
                Email = $"admin@example.com",
                UserName = $"admin@example.com",
                EmailConfirmed = true,
                LockoutEnabled = false
            };

                if ((_context.RoleCollection.Count("{}") == 0) == true)
            {
                var Roles = new List<IdentityRole>()
                {
                    new IdentityRole { Name = "Admin" } ,
                    new IdentityRole { Name = "Registered User" }
                };


                foreach (var role in Roles)
                {
                    await _roleManager.CreateAsync(role);

                }

            }

            if ((_context.UserCollection.Count("{}") == 0) == true)
            {

                await _userManager.CreateAsync(user, $"Admin123!@#");
                await _userManager.AddToRoleAsync(user, "Admin");

            }

            //if ((_context.TodaysPrices.Count("{}") == 0) == true)
            //{
            //   await _context.TodaysPrices.InsertOneAsync(
            //       new Core.Domains.NepSE.TodaysPrice
            //       {
            //            MinPrice=20,
            //            Amount=1,                        
            //       }
            //       );
            //}
            
           
        }   


    }
}
