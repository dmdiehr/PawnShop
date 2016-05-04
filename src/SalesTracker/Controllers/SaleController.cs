using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using SalesTracker.Models;


namespace SalesTracker.Controllers
{
    public class SaleController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateSale()
        {
            return View();
        }
        public IActionResult CreateSale(Sale sale)
        {

            return View();
        }

    }
}
