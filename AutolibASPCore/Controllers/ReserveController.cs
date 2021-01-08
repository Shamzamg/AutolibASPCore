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

            List<VehiculeInfo> vehicules = ReserveService.getVehiculesLibresStation(id);

            List<VehiculeInfo> vehiculesFiltered = new List<VehiculeInfo>();
            List<string> typeVehicules = new List<string>();

            foreach(VehiculeInfo vehicule in vehicules)
            {
                string typeVehicule = vehicule.TypeVehicule;

                if(!typeVehicules.Contains(typeVehicule)){
                    typeVehicules.Add(typeVehicule);
                    vehiculesFiltered.Add(vehicule);
                }
            }

            return View(vehiculesFiltered);
        }
        public IActionResult Reserve()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Car(string dateArrivee, string dateDepart, int vehiculeID)
        {
            if (HttpContext.Session.GetInt32("user") == null)
            {
                HttpContext.Session.SetString("redirectUrl", Url.Action(controller: "Reserve", action: "Station", values: new { }));
                return RedirectToAction(controllerName: "User", actionName: "Login");
            }

            bool isValid = ReserveService.compareDate(dateArrivee, dateDepart);

            if (isValid)
            {
                int userId = (int) HttpContext.Session.GetInt32("user");

                //on réserve la voiture
                ReserveService.reserveVehicule(vehiculeID, userId, dateArrivee, dateDepart);
                return RedirectToAction(controllerName: "Reservation", actionName: "Index");
            }

            string msgErreur = "la date d'arrivée ne peut être inférieure à la date de départ !";
            ViewBag.msgErreur = msgErreur;

            VehiculeInfo vehicule = ReserveService.getVehiculeInfo(vehiculeID);

            return View(vehicule);
        }

        [HttpGet]
        public IActionResult Car(int id)
        {
            if (HttpContext.Session.GetInt32("user") == null)
            {
                HttpContext.Session.SetString("redirectUrl", Url.Action(controller: "Reserve", action: "Station", values: new {  }));
                return RedirectToAction(controllerName: "User", actionName: "Login");
            }

            VehiculeInfo vehicule = ReserveService.getVehiculeInfo(id);

            return View(vehicule);
        }
    }
}
