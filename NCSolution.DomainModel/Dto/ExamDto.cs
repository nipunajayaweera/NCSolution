using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSolution.DomainModel.Dto
{
    public class ExamDto
    {
        public string ExamDescription { get; set; }
        public  DateTime CreatedDate { get; set; }
        public int TotalQuestions { get; set; }

    }
}
