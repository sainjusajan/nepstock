using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        protected ILogger Logger { get; }
        public HomeController(ILoggerFactory loggerFactory, IServiceProvider serviceProvider)
        {
            Logger = loggerFactory.CreateLogger(GetType().Namespace);
            Logger.LogInformation("created homeController");
        }
        
        public IActionResult Index()
        {
           return View();
        }

        public IActionResult Error()
        {   
            return View();
        }
        public IActionResult Careers()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }
        public IActionResult Markets()
        {
            return View();
        }
        public IActionResult Today()
        {
            return View();
        }
    }
}
