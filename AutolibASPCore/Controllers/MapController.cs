using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutolibASPCore.Models.Dao;
using AutolibASPCore.Models.Domain;
using System.Text.Json;

namespace AutolibASPCore.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            List<MapStationData> stations = MapService.getStationsData();
            return View(stations);
        }
        public IActionResult City(string id)
        {
            List<MapStationData> stations = MapService.getStationsData();
            return View(stations);
        }
    }
}
