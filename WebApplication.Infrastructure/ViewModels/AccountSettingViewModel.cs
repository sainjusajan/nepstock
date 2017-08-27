using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Identity;

namespace WebApplication.Infrastructure.ViewModels
{
    public class AccountSettingViewModel
    {
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Occurrence CreatedOn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<IdentityRole> claim { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string BirthCountry { get; set; }
        public string CurrentCountry { get; set; }

        [Required(ErrorMessage = "Please Upload a Valid Image File")]
        [DataType(DataType.Upload)]
        [Display(Name = "Upload Product Image")]
        [FileExtensions(Extensions = "jpg,png,gif,jpeg,bmp,svg")]

        public byte[] Image { get; set; }
    }
}
