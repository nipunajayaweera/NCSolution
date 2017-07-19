using NCSolution.BussinessLayer.Interface;
using NCSolution.DomainModel.Dto;
using NCSolution.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NCSolution.Controllers
{
    public class ExamController : Controller
    {

        private IExamService _examService;

        public ExamController(IExamService examService)
        {
            _examService = examService;
        }





        // GET: Exam
        public ActionResult Index()
        {

            List<ExamDto> exams = _examService.GetAllExamDetails().ToList<ExamDto>();




            return View();
        }
    }
}