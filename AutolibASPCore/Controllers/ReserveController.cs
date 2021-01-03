using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutolibASPCore.Models.Domain;
using AutolibASPCore.Models.Error;
using AutolibASPCore.Models.Dao;
using Microsoft.AspNetCore.Http;

namespace AutolibASPCore.Controllers
{
    public class ReserveController : Controller
    {
        /*
        public IActionResult StationsList()
        {
            List<Station> listeStations = ReserveService.getStationsLibres();

            return View(listeStations);
        }
        */
        public IActionResult Station(int id)
        {
            if(HttpContext.Session.GetInt32("user") == null)
            {
                HttpContext.Session.SetString("redirectUrl", Url.Action(controller: "Reserve", action: "Station", values: new { id }));
                return RedirectToAction(controllerName: "User", actionName: "Login");
            }
            ViewBag.ID = id;
            return View();
        }
        public IActionResult Reserve()
        {
            return View();
        }
    }
}
