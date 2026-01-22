using FinalExamMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalExamMVC.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View(_context.ourPortifolio);
        }
    }
}
