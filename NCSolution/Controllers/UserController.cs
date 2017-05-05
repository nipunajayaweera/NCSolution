using NCSolution.BussinessLayer.Contracts;
using NCSolution.BussinessLayer.Interface;
using NCSolution.DomainModel.Model;
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

        private ILoginUserService _loginUserService;
                                                 

        public UserController(ILoginUserService loginUserService)
        {
            _loginUserService = loginUserService;
        }


        // GET: User
        public ActionResult Index()
        {
            //testing method
             //var username = _loginUserService.GetUserByUserName("sandun");

            //using sps
           //var list =  _loginUserService.GetAll().ToList<LoginUser>();
            //foreach (LoginUser item in list)
            //{

            //}


            return View();
        }

        public ActionResult LogOrRegister(bool IsLogin)
        {
            
            if (IsLogin)
            {
                LoginUserVM LU = new LoginUserVM();
                return PartialView("_Login");
            }
            else
            {
                return PartialView("_Register");
            }
        }

        [HttpPost]
        public ActionResult Login(LoginUserVM lu)
        {
            //var usr = _loginUserService.GetUserByUserName(lu.UserName);

            //if (usr != null)
            //{
            //    if (usr.Email == lu.Password)
            //    {
            //        return RedirectToAction("Exam", "Default");
            //    }

            //}
            //return View("Index");

            if (lu.UserName == "admin")
            {
                return RedirectToAction("Index","Admin");
            }
                    return RedirectToAction("Exam", "Default");
            //    }
            //        else
            //        {
            //            ModelState.AddModelError("Password", "Password incorrect");
            //            return View("Index",lu);
            //        }

            //}
            //return View("Index");
        }

        [HttpPost]
        public ActionResult Register(string user)
        {
            return View();
        }
    }
}