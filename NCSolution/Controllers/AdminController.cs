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
    }
}