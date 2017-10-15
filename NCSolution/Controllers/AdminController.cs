using NCSolution.BussinessLayer.Interface;
using NCSolution.DomainModel.Dto;
using NCSolution.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        public ActionResult ShowQuestionTestNew()
        {
            List<Chapter> ChapterList = new List<Chapter>();
            ChapterList = CreateChaptes();
            return View(ChapterList);
        }





        private List<Chapter> CreateChaptes()
        {
            //DataSet set = new DataSet("DataBase");

            //DataTable Question = new DataTable("Question");
            //Question.Columns.Add("Id");
            //Question.Columns.Add("Question");
            //Question.Columns.Add("Id");
            //Question.Columns.Add("Id");
            List<Chapter> ChapterList = new List<Chapter>();
            for (int i = 1; i < 8; i++)
            {
                List<Section> SecL = new List<Section>();
                for (int j = 1; j < 5; j++)
                {
                    List<Question> queL = new List<Question>();
                    for (int k = 0; k < 5; k++)
                    {
                        List<Answer> ansL = new List<Answer>();
                        for (int x = 1; x < 5; x++)
                        {
                            Answer ans = new Answer
                            {
                                Id = x,
                                AnswerName = "Answer = " + x
                            };
                            ansL.Add(ans);
                        }


                        Question que = new Question
                        {
                            Id = k,
                            QuestionBody = "Question - " + k,
                            CorrectAnswerId = 3,
                            AnswerList = ansL
                        };
                        queL.Add(que);
                    }

                    Section sec = new Section
                    {
                        SectionId = j+27*i,
                        SectionName = "Section - " + j,
                        QuestionList = queL
                    };
                    SecL.Add(sec);
                }
                Chapter ch = new Chapter
                {
                    ChapterId = i,
                    ChapterName = "Chapter - " + i,
                    SectionList = SecL
                };
                ChapterList.Add(ch);
            }
            return ChapterList;

        }


    }
}