using Microsoft.AspNetCore.Mvc;

namespace FinalExamMVC.Areas.Admin.Controllers.Dashboard
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
