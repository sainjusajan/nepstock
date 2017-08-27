using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Infrastructure.ViewModels.ProfileViewModels;

namespace WebApplication.Infrastructure.Interface.Services
{
    public interface IProfileSettingViewModelService
    {
        General GetGeneralSetting();
        Security GetSecuritySetting();
    }
}
