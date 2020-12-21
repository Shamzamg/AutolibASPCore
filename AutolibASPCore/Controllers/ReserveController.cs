using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AutolibASPCore.Controllers
{
    public class ReserveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StationsList()
        {
            return View();
        }
        public IActionResult Station()
        {
            return View();
        }
        public IActionResult Reserve()
        {
            return View();
        }
    }
}
