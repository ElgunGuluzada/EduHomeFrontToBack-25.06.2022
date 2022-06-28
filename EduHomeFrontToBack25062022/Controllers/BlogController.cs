using EduHomeFrontToBack25062022.DAL;
using EduHomeFrontToBack25062022.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EduHomeFrontToBack25062022.Controllers
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
            ViewBag.Name = "Blog";
            BlogVM blogVM = new BlogVM();
            blogVM.Blogs = _context.Blogs.ToList();
            blogVM.Writers = _context.Writers.ToList();
            return View(blogVM);
        }
    }
}
