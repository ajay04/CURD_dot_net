using Microsoft.AspNetCore.Mvc;
using YourProjectName.Models;
using System.Linq;

namespace YourProjectName.Controllers
{
    public class ItemsController : Controller
    {
        private readonly AppDbContext _context;
        public ItemsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items = _context.Items.ToList();
            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Item item)
        {
            if (item == null || string.IsNullOrWhiteSpace(item.Name))
                return BadRequest("Invalid item data.");
            _context.Items.Add(item);
            _context.SaveChanges();
            return Json(new { success = true, redirectUrl = Url.Action("Index") });
        }

        public IActionResult Edit(int id)
        {
            var item = _context.Items.Find(id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit([FromBody] Item item)
        {
            if (item == null || string.IsNullOrWhiteSpace(item.Name))
                return BadRequest("Invalid item data.");
            _context.Items.Update(item);
            _context.SaveChanges();
            return Json(new { success = true, redirectUrl = Url.Action("Index") });
        }

        public IActionResult Delete(int id)
        {
            var item = _context.Items.Find(id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete([FromBody] Item item)
        {
            if (item == null || item.Id == 0)
                return BadRequest("Invalid item data.");
            var dbItem = _context.Items.Find(item.Id);
            if (dbItem == null)
                return NotFound("Item not found.");
            _context.Items.Remove(dbItem);
            _context.SaveChanges();
            return Json(new { success = true, redirectUrl = Url.Action("Index") });
        }

        public IActionResult Details(int id)
        {
            var item = _context.Items.Find(id);
            if (item == null) return NotFound();
            return View(item);
        }
    }
}
