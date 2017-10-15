using NCSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
                q.QuestionIndex = i;
                q.QuestionNo = i;
                q.Question = "you Question " + i;
                Answer ans1=new Answer { Id=1,AnswerName= "Answer 1 -"+i };
                Answer ans2=new Answer { Id=2,AnswerName= "Answer 2 -"+i };
                Answer ans3=new Answer { Id=3,AnswerName= "Answer 3 -"+i };
                Answer ans4=new Answer { Id=4,AnswerName= "Answer 4 -"+i };

                List<Answer> answerlist = new List<Answer>();
                
                answerlist.Add(ans1);
                answerlist.Add(ans2);
                answerlist.Add(ans3);
                answerlist.Add(ans4);
                q.AnswerList = answerlist;
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
        [HttpPost]
        public ActionResult NextButtonAction(Que Q)
        {
            int nextQuectionId = Q.QuestionIndex+1;

            QuestionList[Q.QuestionIndex-1].SelectedAnswerId=Q.SelectedAnswerId;


            return RedirectToAction("Question", new {id= nextQuectionId });
        }

        public ActionResult Finalize()
        {
            FinalSummury FS = new FinalSummury();

            List<QuestionFinalize> QFList = new List<QuestionFinalize>();
            Thread.Sleep(3000);
            foreach (var item in QuestionList)
            {
                QuestionFinalize QF = new QuestionFinalize
                {
                    QuestionId = item.QuestionIndex,
                    Question = item.Question,
                    YourAnswer = item.SelectedAnswerId,
                    IsCorrect = (item.QuestionIndex % 2 == 0) ? true : false
                };
                QFList.Add(QF);
            }
            FS.FinalizeQuestionList = QFList;
            FS.CorrectAnswers =20;
            FS.NoOfQuestions = 40;
            return View(FS);
        }
    }
}