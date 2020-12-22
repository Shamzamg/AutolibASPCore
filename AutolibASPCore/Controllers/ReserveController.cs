using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutolibASPCore.Models.Domain;
using AutolibASPCore.Models.Error;
using AutolibASPCore.Models.Dao;

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
            List<Station> listeStations = ReserveService.getStationsLibres();

            return View(listeStations);
        }
        public IActionResult Station(int id)
        {
            ViewBag.ID = id;
            List<StationData> listeStations = ReserveService.getStationData(id);
            return View(listeStations);
        }
        public IActionResult Reserve()
        {
            return View();
        }
    }
}
