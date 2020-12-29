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
        public IActionResult City()
        {
            List<MapStationData> markers = MapService.getStationsData();
            return View(markers);
        }
    }
}
