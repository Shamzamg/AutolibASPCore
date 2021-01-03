using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutolibASPCore.Models.Domain;
using AutolibASPCore.Models.Dao;
using CryptoHelper;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace AutolibASPCore.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View(null);
        }
        [HttpPost]
        public IActionResult Login(string email, string passwd)
        {
            UserAuthCode code = login(email, passwd);
            if (code == UserAuthCode.SUCCESS)
            {
                return redirectOnLogged();
            }
            return View(code);
        }
        public IActionResult Register()
        {
            return View(null);
        }
        [HttpPost]
        public IActionResult Register(string email, string passwd, string firstname, string lastname, string birthdate)
        {
            UserAuthCode code = register(email, passwd, firstname, lastname, birthdate);
            if(code == UserAuthCode.SUCCESS)
            {
                return redirectOnLogged();
            }
            return View(code);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user");
            return RedirectToAction(controllerName: "Home", actionName: "Index");
        }
        public IActionResult Account()
        {
            return View();
        }
        private bool isEmailValid(string email)
        {
            var attr = new EmailAddressAttribute();
            return email.Length < 255 && attr.IsValid(email);
        }
        private bool isPasswdValid(string passwd)
        {
            return passwd.Length > 4 && passwd.Length < 255;
        }
        private UserAuthCode login(string email, string passwd)
        {
            if(!isEmailValid(email))
            {
                return UserAuthCode.USER_NOT_EXISTS;
            }
            if (!isPasswdValid(passwd))
            {
                return UserAuthCode.WRONG_PASSWORD;
            }
            var user = UserService.getOne(email);
            if(user == null)
            {
                return UserAuthCode.USER_NOT_EXISTS;
            } else if(!Crypto.VerifyHashedPassword(user.Passwd, passwd))
            {
                return UserAuthCode.WRONG_PASSWORD;
            } else
            {
                HttpContext.Session.SetInt32("user", user.IdClient);
                return UserAuthCode.SUCCESS;
            }
        }
        private IActionResult redirectOnLogged()
        {
            var redirectUrl = HttpContext.Session.GetString("redirectUrl");
            if (redirectUrl != null)
            {
                HttpContext.Session.Remove("redirectUrl");
                return Redirect(redirectUrl);
            } else
            {
                return RedirectToAction(controllerName: "Home", actionName: "Index");
            }
        }
        private UserAuthCode register(string email, string passwd, string firstname, string lastname, string birthdate)
        {
            if (!isEmailValid(email))
            {
                return UserAuthCode.BAD_EMAIL_FORMAT;
            }
            if (!isPasswdValid(passwd))
            {
                return UserAuthCode.BAD_PASSWORD_FORMAT;
            }
            if (firstname.Length == 0 || firstname.Length > 45)
            {
                return UserAuthCode.NO_BIRTHDATE;
            }
            if (lastname.Length == 0 || lastname.Length > 45)
            {
                return UserAuthCode.NO_BIRTHDATE;
            }
            if (birthdate.Length == 0 || birthdate.Length > 100)
            {
                return UserAuthCode.NO_BIRTHDATE;
            }
            if (UserService.getOne(email) != null)
            {
                return UserAuthCode.USER_ALREADY_EXISTS;
            }
            
            var passwdHash = Crypto.HashPassword(passwd);
            DateTime? birthdateParsed = null;
            try
            {
                birthdateParsed = DateTime.Parse(birthdate);
            } catch(FormatException)
            {
                return UserAuthCode.NO_BIRTHDATE;
            }
            UserService.addOne(email, passwdHash, firstname, lastname, (DateTime)birthdateParsed);

            return login(email, passwd);
        }
    }
}
