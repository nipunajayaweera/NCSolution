using NCSolution.BussinessLayer.Interface;
using NCSolution.DomainModel.Dto;
using NCSolution.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

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

            //
            // List<ExamChapterDto> examChapters = _examService.GetChapters(1).ToList<ExamChapterDto>();

            List<ExamDto> exams = _examService.GetAllExamDetails().ToList<ExamDto>();


            return View();
        }
        
        public JsonResult GetExamDataToJson()
        {
            List<ExamDto> exams = _examService.GetAllExamDetails().ToList<ExamDto>();
            var examListObject = exams.Select(i=> 
                new
                {
                    ExamDescription = i.ExamDescription,
                    CreateDate = i.CreatedDate.ToString("MM/dd/yyyy"),
                    TotalQuestions = i.TotalQuestions
                });


            //var a = Json(examListObject, JsonRequestBehavior.AllowGet);
            //return a;

            return Json(new { data = examListObject }, JsonRequestBehavior.AllowGet);
        }

        
     
    }
}