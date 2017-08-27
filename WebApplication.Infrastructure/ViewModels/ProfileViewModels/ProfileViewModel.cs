using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Identity;

namespace WebApplication.Infrastructure.ViewModels.ProfileViewModels
{
    public class ProfileViewModel
    {
        public string Id { get; set; }
        public Task<string> UserName { get; set; }

        public Task<string> Email { get; set; }
        public Task<string> PhoneNumber { get; set; }
        public Occurrence CreatedOn { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string BirthCountry { get; set; }

        public string CurrentCountry { get; set; }
                
        public Task<IList<string>> Roles { get; set; }

        public List<string> Ids { get; set; } = new List<string>();

        public byte[] Image { get; set; }

    }
}
