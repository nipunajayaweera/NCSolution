using NCSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NCSolution.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Question(int id)
        {
            Que Q = new Que();
            Q.QuestionNo = id;
            
            return View(Q);
        }

        public ActionResult LoadQue(int id)
        {
            Que Q = new Que();
            Q.QuestionNo = id;
            return PartialView("_LoadQue",Q);
        }
    }
}