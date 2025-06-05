using Microsoft.AspNetCore.Mvc;
using YourProjectName.Models;
using System.Linq;

namespace YourProjectName.Controllers
{
    public class SubItemsController : Controller
    {
        private readonly AppDbContext _context;
        public SubItemsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int itemId)
        {
            var subItems = _context.SubItems.Where(s => s.ItemId == itemId).ToList();
            ViewBag.ItemId = itemId;
            return View(subItems);
        }

        public IActionResult Create(int itemId)
        {
            ViewBag.ItemId = itemId;
            return View();
        }

        [HttpPost]
        public IActionResult Create(SubItem subItem)
        {
            if (ModelState.IsValid)
            {
                _context.SubItems.Add(subItem);
                _context.SaveChanges();
                return RedirectToAction("Index", new { itemId = subItem.ItemId });
            }
            ViewBag.ItemId = subItem.ItemId;
            return View(subItem);
        }
    }
}
