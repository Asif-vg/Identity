using EduHome.Data;
using EduHome.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller
    {
        private readonly AppDbContext _context;

        public BannerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Banner> model = _context.Banners.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Banner model)
        {
            if (ModelState.IsValid)
            {
                _context.Banners.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }

            ModelState.AddModelError("", "Error var");

            return View(model);
        }

        public IActionResult Update(int id)
        {
            return View(_context.Banners.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Banner model)
        {
            if (ModelState.IsValid)
            {
                _context.Banners.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }

            ModelState.AddModelError("", "Error var");

            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            if (id==null)
            {
                HttpContext.Session.SetString("NullIdError" , "id null ola bilmez");
                return RedirectToAction("Index");

            }

            Banner banner = _context.Banners.Find(id);
            if (banner == null)
            {
                HttpContext.Session.SetString("NullDataError", "data tapilmadi");
                return RedirectToAction("Index");

            }
            _context.Banners.Remove(banner);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
