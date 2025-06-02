using Microsoft.AspNetCore.Mvc;
using YourProjectName.Models;
using System.Collections.Generic;
using System.Linq;

namespace YourProjectName.Controllers
{
    public class ItemsController : Controller
    {
        private static List<Item> items = new List<Item>();
        private static int nextId = 1;

        public IActionResult Index()
        {
            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            if (ModelState.IsValid)
            {
                item.Id = nextId++;
                items.Add(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }

        public IActionResult Edit(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(Item item)
        {
            var existing = items.FirstOrDefault(i => i.Id == item.Id);
            if (existing == null) return NotFound();
            if (ModelState.IsValid)
            {
                existing.Name = item.Name;
                return RedirectToAction("Index");
            }
            return View(item);
        }

        public IActionResult Delete(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null) return NotFound();
            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item != null)
                items.Remove(item);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null) return NotFound();
            return View(item);
        }
    }
}
