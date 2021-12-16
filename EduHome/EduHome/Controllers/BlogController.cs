using EduHome.Data;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmBlog model = new VmBlog() {

                Setting= _context.Settings.FirstOrDefault(),
                Blogs = _context.Blogs.ToList(),
                Banner= _context.Banners.FirstOrDefault(b => b.Page== "blog"),
                BlogCategorys =_context.BlogCategorys.ToList(),
                Tags=_context.Tags.ToList()

            };
            return View(model);
        }
    }
}
