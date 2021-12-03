using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TennisTime.Models;
using Microsoft.EntityFrameworkCore;
namespace TennisTime.Controllers
{
    public class TennisController : Controller
    {
		private RacquetContext context { get; set; }

		public TennisController(RacquetContext ctx)
		{
			context = ctx;
		}
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult Rules()
		{
			return View();
		}
		public IActionResult Equipment()
		{
			var racquets = context.Racquets
				.Include(g => g.Make)
				.OrderBy(g => g.Model)
				.ToList();
			return View(racquets);

		}
		public IActionResult WorldRecords()
		{
			return View();
		}
		public IActionResult History()
		{
			return View();
		}

	}
}
