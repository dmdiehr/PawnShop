using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace SalesTracker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Associates()
        {
            ViewData["Message"] = "Sales Associate Page";

            return View();
        }

        public IActionResult Managers()
        {
            ViewData["Message"] = "Sales Manager Page";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
