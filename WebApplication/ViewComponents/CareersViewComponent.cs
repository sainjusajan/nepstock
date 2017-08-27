using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Infrastructure;
using MongoDB.Driver;

namespace WebApplication.ViewComponents
{
    public class CareersViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public CareersViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var item = await _context.Careers.FindAsync("{}");

            return View(item.ToListAsync());
        }
    }
}
