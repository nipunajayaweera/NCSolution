using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NCSolution.Models
{
    class QuestionViewModel
    {
    }

    public class AddNewQuestion
    {
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string CorrectAnswer { get; set; }
        public string Chapter { get; set; }
        public SelectList ChaptersList { get; set; }
        public SelectList SectionList { get; set; }
    }
    
}
