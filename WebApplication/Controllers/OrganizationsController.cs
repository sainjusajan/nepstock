//using Microsoft.AspNetCore.Mvc;
//using MongoDB.Driver;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using WebApplication.Core.Domains;
//using WebApplication.Infrastructure;

//namespace WebApplication.Controllers
//{
//    public class OrganizationsController : Microsoft.AspNetCore.Mvc.Controller
//    {
//        private readonly ApplicationDbContext _context = new ApplicationDbContext();

//        public async Task<IActionResult> IndexAsync()
//        {
//           // var item = await _context.Organizations.FindAsync("{}");

//            return View(item);
//        }


//        [HttpGet]
//        public IActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult Create(Organization model)
//        {
//            if (ModelState.IsValid)
//            {
//                Organization item = new Organization
//                {
//                    Id = model.Id,
//                     Name = model.Name,
//                      Location = model.Location,
//                      Symbool = model.Symbool
//                };

//                _context.Organizations.InsertOne(item);
//            }
//            else
//            {
//                return View(model);
//            };

//            return RedirectToAction("Index");
//        }

//        public async Task<IActionResult> Details(string id)
//        {

//            if (id == null)
//            {
//                return NotFound();
//            }

//            var queryresult = await _context.Organizations.FindAsync(id);

//            if (queryresult == null)
//            {
//                return NotFound();
//            }

//            return View(queryresult);
//        }

//        public async Task<IActionResult> Edit(string id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }
//            var queryresult = await _context.Organizations.FindAsync(id);
//            if (queryresult == null)
//            {
//                return NotFound();
//            }

//            return View(queryresult);
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(Organization model)
//        {

//            if (ModelState.IsValid)
//            {
//                Organization item = new Organization
//                {
//                    Id = model.Id,
                  

//                };


//                //await _context.Organizations.FindOneAndUpdate(item);

//                return RedirectToAction("Index");
//            }
//            return View();
//        }


//        public async Task<IActionResult> Delete(string id)
//        {

//            if (id == null)
//            {
//                return NotFound();
//            }
//            var queryresult = await _context.Organizations.FindAsync(id);

//            if (queryresult == null)
//            {
//                return NotFound();
//            }

//            return View(queryresult);
//        }


//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(string id)
//        {
//            var item = await _context.Organizations.FindAsync(id);
//            //await _context.Organization.DeleteOneAsync(item);

//            return RedirectToAction("Index");
//        }










//    }
//}
