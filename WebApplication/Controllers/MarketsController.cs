using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class MarketsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CompanyDetail()
        {
            return View();
        }
    }
}