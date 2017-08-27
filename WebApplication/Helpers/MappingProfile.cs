using AutoMapper;
using WebApplication.Identity;
using WebApplication.Infrastructure.ViewModels;
using WebApplication.Infrastructure.ViewModels.ProfileViewModels;

namespace WebApplication.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           
            CreateMap<IdentityUser, UserViewModel>();
            CreateMap<IdentityRole, RoleViewModel>();
            

        }
        
    }
}
