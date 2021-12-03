using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TennisTime.Controllers
{
    public class TennisController : Controller
    {
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
			// var Make = "";
			// var Model = "";
			// var year = "";
			// var Price = "";

			return View();
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
