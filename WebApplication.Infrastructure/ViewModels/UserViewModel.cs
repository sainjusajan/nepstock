using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Infrastructure.ViewModels
{
    public class UserViewModel
    {

        
        public string Id { get; set; }


        [Display(Name = "User Name")]
        public string UserName { get; set; }


        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        public List<string> RoleNames { get; set; } = new List<string>();

        public List<string> Ids { get; set; } = new List<string>();

    }

    public class UserChangePasswordViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
