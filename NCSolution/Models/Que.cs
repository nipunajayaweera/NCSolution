using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSolution.Models
{
    public class Que
    {
        public int QuestionIndex { get; set; }
        public int QuestionNo { get; set; }
        public string Question { get; set; }
        public List<Answer> AnswerList { get; set; }
        public int SelectedAnswerId { get; set; }
    }

    public class Answer
    {
        public int Id { get; set; }
        public string AnswerName { get; set; }
    }
}
