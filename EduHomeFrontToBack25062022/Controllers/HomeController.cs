using EduHomeFrontToBack25062022.DAL;
using EduHomeFrontToBack25062022.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EduHomeFrontToBack25062022.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Sliders = _context.Sliders.ToList();
            homeVM.SliderContent = _context.SliderContents.FirstOrDefault();
            homeVM.NoticeLeftSides= _context.NoticeLeftSides.ToList();
            homeVM.NoticeRightSides= _context.NoticeRightSides.ToList();
            homeVM.Choose = _context.Chooses.FirstOrDefault();

            return View(homeVM);
        }
    }
}
