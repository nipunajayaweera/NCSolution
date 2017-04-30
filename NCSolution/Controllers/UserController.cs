using NCSolution.BussinessLayer.Contracts;
using NCSolution.BussinessLayer.Interface;
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
            var username = _loginUserService.GetUserByUserName("sandun");




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
        }

        [HttpPost]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterUser user)
        {
            return View();
        }
    }
}