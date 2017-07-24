using NCSolution.BussinessLayer.Interface;
using NCSolution.DomainModel.Dto;
using NCSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NCSolution.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddNewQuestion()
        {
            var model = new AddNewQuestion();
            model.ChaptersList = new SelectList(new List<SelectListItem>
                                                {
                                                    new SelectListItem {Text = "Chapter 1", Value = "1"},
                                                    new SelectListItem {Text = "Chapter 2", Value = "2"},
                                                    new SelectListItem {Text = "Chapter 3", Value = "3"},
                                                    new SelectListItem {Text = "Chapter 4", Value = "4"},
                                                    new SelectListItem {Text = "Chapter 5", Value = "4"},
                                                    new SelectListItem {Text = "Chapter 6", Value = "4"},
                                                    new SelectListItem {Text = "Chapter 7", Value = "4"},
                                                }, "Value", "Text");

            model.SectionList = new SelectList(new List<SelectListItem>
                                                {
                                                    new SelectListItem {Text = "section 1", Value = "1"},
                                                    new SelectListItem {Text = "section 2", Value = "2"},
                                                    new SelectListItem {Text = "section 3", Value = "3"},
                                                    new SelectListItem {Text = "section 4", Value = "4"},
                                                }, "Value", "Text");
            return View("Add_New_Question", model);
        }

        [HttpPost]
        public ActionResult AddNewQuestion(AddNewQuestion que)
        {
            return RedirectToAction("AddNewQuestion");
        }

        public ActionResult ShowQuestion()
        {
            return View();
        }



        //private IAdminService _adminService;
        //public AdminController(IAdminService adminService)
        //{
        //    _adminService = adminService;
        //}

        public JsonResult GetExamDataToJson()
        {
            List<QuestionDto> questions = GenQuestions(); //_adminService.AllQuestions().ToList<QuestionDto>();
            var QuestionListObject = questions.Select(i =>
                new
                {
                    QuestionsDescription = i.Question,
                    Answer1 = i.Answer1,
                    Answer2 = i.Answer2,
                    Answer3 = i.Answer3 ,
                    Answer4 = i.Answer4,
                    CorrectAnswer = i.CorrectAnswer
                });


            //var a = Json(examListObject, JsonRequestBehavior.AllowGet);
            //return a;

            return Json(new { data = QuestionListObject }, JsonRequestBehavior.AllowGet);
        }

        public List<QuestionDto> GenQuestions()
        {
            List<QuestionDto> list=new List<QuestionDto>();

            list.Add(new QuestionDto { Question = "Question number 1", Answer1 = "Answer1", Answer2 = "Answer2", Answer3 = "Answer3", Answer4 = "Answer4", CorrectAnswer = 1 });
            list.Add(new QuestionDto { Question = "Question number 2", Answer1 = "Answer1", Answer2 = "Answer2", Answer3 = "Answer3", Answer4 = "Answer4", CorrectAnswer = 1 });
            list.Add(new QuestionDto { Question = "Question number 3", Answer1 = "Answer1", Answer2 = "Answer2", Answer3 = "Answer3", Answer4 = "Answer4", CorrectAnswer = 1 });
            list.Add(new QuestionDto { Question = "Question number 4", Answer1 = "Answer1", Answer2 = "Answer2", Answer3 = "Answer3", Answer4 = "Answer4", CorrectAnswer = 1 });
            list.Add(new QuestionDto { Question = "Question number 5", Answer1 = "Answer1", Answer2 = "Answer2", Answer3 = "Answer3", Answer4 = "Answer4", CorrectAnswer = 1 });
            list.Add(new QuestionDto { Question = "Question number 6", Answer1 = "Answer1", Answer2 = "Answer2", Answer3 = "Answer3", Answer4 = "Answer4", CorrectAnswer = 1 });

            return list;
        }
    }
}