using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Infrastructure.Interface.Services;

namespace WebApplication.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Dashboard";
            //_viewModelService.GetUserDashboardViewModel()
            return View();
        }

    }
}
