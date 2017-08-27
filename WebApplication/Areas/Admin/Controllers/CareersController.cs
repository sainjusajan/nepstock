using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WebApplication.Identity;
using WebApplication.Infrastructure;
using MongoDB.Driver;
using WebApplication.Core.Domains;
using WebApplication.Infrastructure.Repository;

namespace WebApplication.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CareersController : Controller
    {
        private readonly ICareersRepository _CareersRepository;

        public CareersController(ICareersRepository CareersRepository) => _CareersRepository = CareersRepository;
        public async Task<IActionResult> Index()
        {
            var item = await _CareersRepository.FindAll();

            return View(item);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Careers model)
        {
            if (ModelState.IsValid)
            {
                Careers item = new Careers
                {
                     Title = model.Title,
                     DeadLine = model.DeadLine,
                       PublishDate = DateTime.Now,
                     PublishedBy = $"admin",

                     Body = Request.Form["editor1"].ToString(),

                };

                _CareersRepository.Save(item);
            }
            else
            {
                return View(model);
            };

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var queryresult = await _CareersRepository.Get(id);

            if (queryresult == null)
            {
                return NotFound();
            }

            return View(queryresult);
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var queryresult = await _CareersRepository.Get(id);
            if (queryresult == null)
            {
                return NotFound();
            }

            return View(queryresult);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Careers model)
        {

            if (ModelState.IsValid)
            {
                Careers item = new Careers
                {
                    Title = model.Title,
                    DeadLine = model.DeadLine,
                              PublishDate = DateTime.Now,
                    PublishedBy = $"admin",

                    Body = Request.Form["editor1"].ToString(),

                };


                await _CareersRepository.Update(item);

                return RedirectToAction("Index");
            }
            return View();
        }


        public async Task<IActionResult> Delete(string id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var queryresult = await _CareersRepository.Get(id);

            if (queryresult == null)
            {
                return NotFound();
            }

            return View(queryresult);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var item = await _CareersRepository.Get(id);
            await _CareersRepository.Delete(item);

            return RedirectToAction("Index");
        }


    }
}
