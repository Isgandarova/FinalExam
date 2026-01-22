using FinalExamMVC.Data;
using FinalExamMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalExamMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OurPortifolioController : Controller
    {

        private AppDbContext _context;
        public OurPortifolioController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View(_context.ourPortifolio);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(OurPortifolio model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            _context.ourPortifolio.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            var existItem = _context.ourPortifolio.FirstOrDefault(item => item.Id == id);
            if (existItem == null)
            {
                return NotFound();
            }
            _context.ourPortifolio.Remove(existItem);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int? id)
        {
            var existItem = _context.ourPortifolio.FirstOrDefault(item => item.Id == id);
            if (existItem == null)
            {
                return NotFound();
            }
            return View(existItem);
        }
        [HttpPost]
        public async Task<IActionResult>Update(OurPortifolio model, int? id)
        {
            var existItem = _context.ourPortifolio.FirstOrDefault(item => item.Id == id);
            if (existItem == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            existItem.ImageUrl = model.ImageUrl;
            existItem.Title = model.Title;
            existItem.Category = model.Category;
            existItem.UpdatedAt = model.UpdatedAt;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}