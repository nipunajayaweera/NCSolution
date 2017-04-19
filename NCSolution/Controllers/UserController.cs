using NCSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NCSolution.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogOrRegister(bool IsLogin)
        {
            
            if (IsLogin)
            {
                LoginUser LU = new LoginUser();
                return PartialView("_Login",LU);
            }
            else
            {
                return PartialView("_Register");
            }


            return PartialView((IsLogin) ? "_Login" : "_Register");
            
        }
        [HttpPost]
        public ActionResult Login(LoginUser LU)
        {
            return View();
        }
    }
}