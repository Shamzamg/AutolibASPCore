using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutolibASPCore.Models.Domain;
using AutolibASPCore.Models.Dao;
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
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string passwd)
        {
            var user = UserService.getOne(email);
            if (user != null && Crypto.VerifyHashedPassword(user.Passwd, passwd))
            {
                // Log user
                return RedirectToAction(controllerName: "Home", actionName: "Index");
            }

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
