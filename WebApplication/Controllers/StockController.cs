using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Infrastructure;
using WebApplication.Infrastructure.Repository;

namespace WebApplication.Controllers
{
    public class StockController : Controller
    {
         private readonly ApplicationDbContext context =  new ApplicationDbContext();
        
      
        public async Task<IActionResult> Index()
        {
            var item = await context.StockData.Find("{}").ToListAsync();

            return View(item);
        }

                        
    }
}
