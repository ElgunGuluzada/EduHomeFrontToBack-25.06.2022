using EduHomeFrontToBack25062022.DAL;
using EduHomeFrontToBack25062022.Models;
using EduHomeFrontToBack25062022.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EduHomeFrontToBack25062022.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            @ViewBag.Name = "Our Teachers";
            TeacherVM teacherVM = new TeacherVM();
           teacherVM.Teachers  = _context.Teachers.ToList();
            return View(teacherVM);
        }
    }
}
