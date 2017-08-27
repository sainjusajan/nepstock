using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Infrastructure.ViewModels;

namespace WebApplication.Infrastructure.Interface.Services
{
    public interface IViewModelService
    {
        TileViewModel GetUserDashboardViewModel();

    }
}
