using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TennisTime.Models;

namespace TennisTime.Controllers
{
    public class RacquetController : Controller
    {
        private RacquetContext context { get; set; }

        public RacquetController(RacquetContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Makes = context.Make.OrderBy(g => g.Name).ToList();
            return View("Edit", new Racquet());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Makes = context.Make.OrderBy(g => g.Name).ToList();
            var racquet = context.Racquets.Find(id);
            return View(racquet);
        }

        [HttpPost]
        public IActionResult Edit(Racquet racquet)
        {
            if (ModelState.IsValid)
            {
                if (racquet.RacquetId == 0) 
                    context.Racquets.Add(racquet);
                else 
                    context.Racquets.Update(racquet);
                context.SaveChanges();
                return RedirectToAction("Equipment", "Tennis");
            }
            else
            {
                ViewBag.Action = (racquet.RacquetId == 0) ? "Add": "Edit";
                ViewBag.Makes = context.Make.OrderBy(g => g.Name).ToList();
                return View(racquet);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var racquet = context.Racquets.Find(id);
            return View(racquet);
        }

        [HttpPost]
        public IActionResult Delete(Racquet racquet)
        {
            context.Racquets.Remove(racquet);
            context.SaveChanges();
            return RedirectToAction("Equipment", "Tennis");
        }
    }
}