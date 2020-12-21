using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutolibASPCore.Models.Domain;
using CryptoHelper;

namespace AutolibASPCore.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            // var hash = Crypto.HashPassword("d6506c7bcf0d483354d2eca58ed6611ea11a134a13e7d1940b3ce549ec024943");
            // Crypto.VerifyHashedPassword(hash, "test");
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Account()
        {
            return View();
        }
    }
}
