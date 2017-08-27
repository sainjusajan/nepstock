﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Infrastructure.ViewModels.ProfileViewModels
{
    public class EditProfileViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }
        [Display(Name = "Birth Country")]
        public string BirthCountry { get; set; }
        [Display(Name = "Current Country")]
        public string CurrentCountry { get; set; }
        
        public List<string> Roles { get; set; }
        
        public byte[] Image { get; set; }

    }
}
