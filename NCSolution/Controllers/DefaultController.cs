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
        public static List<Que> QuestionList = new List<Que>();
        private void AddQuestions()
        {
            Que q ;
            for (int i = 1; i < 41; i++)
            {
                q = new Que();
                q.QuestionNo = i;
                q.Question = "you Question " + i;
                QuestionList.Add(q);
            }
        }


        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Question(int id)
        {
            //Que Q = new Que();
            //Q.QuestionNo = id;
            Que Q = new Que();
            Q = QuestionList[id-1];
            return View(Q);
        }

        public ActionResult LoadQue(int id)
        {
            Que Q = new Que();
            //Q.QuestionNo = id;
            Q = QuestionList[id-1];
            return PartialView("_LoadQue",Q);
        }

        public ActionResult Exam()
        {
            AddQuestions();
            return View("ExamDescription");
        }
    }
}