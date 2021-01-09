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
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("user") == null)
            {
                HttpContext.Session.SetString("redirectUrl", Url.Action(controller: "Reservation", action: "Index", values: new {  }));
                return RedirectToAction(controllerName: "User", actionName: "Login");
            }

            int userId = (int) HttpContext.Session.GetInt32("user");

            List <ReservationInfo> reservations = ReservationService.getReservation(userId);

            return View(reservations);
        }

        [HttpPost]
        public IActionResult Index(int idClient, int idBorneDepart, int idVehicule)
        {
            if (HttpContext.Session.GetInt32("user") == null)
            {
                HttpContext.Session.SetString("redirectUrl", Url.Action(controller: "Reserve", action: "Station", values: new { }));
                return RedirectToAction(controllerName: "User", actionName: "Login");
            }

            ReservationService.annulerReservation(idClient, idVehicule, idBorneDepart);

            List<ReservationInfo> newreservations = ReservationService.getReservation(idClient);

            return View(newreservations);
        }

    }
}
