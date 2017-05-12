using NCSolution.BussinessLayer.Interface;
using NCSolution.DomainModel.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NCSolution.Controllers
{
    public class DefaultController : Controller
    {
        private ILoginUserService _loginUserService;
        public static  List<Question> _questionList;
        public DefaultController(ILoginUserService loginUserService)
        {
            _loginUserService = loginUserService;

            _questionList = new List<DomainModel.Model.Question>();

        }


        
        private void AddQuestions()
        {
            
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
            
            Question Q = _questionList[id-1];
            return View(Q);
        }

        public ActionResult LoadQue(int id)
        {
            
            //Q.QuestionNo = id;
            Question Q = _questionList[id-1];
            return PartialView("_LoadQue",Q);
        }

        public ActionResult Exam()
        {
            _questionList = _loginUserService.QuestionsForNextExamAttempt(1016);
            //AddQuestions();
            return View("ExamDescription");
        }
    }
}