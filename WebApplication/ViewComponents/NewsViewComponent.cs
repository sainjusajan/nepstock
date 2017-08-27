using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Infrastructure;

namespace WebApplication.ViewComponents
{
    public class NewsViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public NewsViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var item = await _context.News.FindAsync("{}").Result.ToListAsync();

            var data = from s in item
                       select s;
            
            return View(data.Take(5).ToList());
        }
    }
}
