using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Infrastructure.Interface.Services;
using WebApplication.Infrastructure.ViewModels;

namespace WebApplication.Infrastructure.Services
{
    public class ViewModelService : IViewModelService
    {
        public TileViewModel GetUserDashboardViewModel()
        {
            return new TileViewModel
            {
                Title = "User Info",
                ColorCssClass = "panel-primary",
                IconCssClass = "fa-slider",

            };

        }

    }
}
