using NCSolution.DomainModel.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSolution.DomainModel.Model
{
    [Table("UserExamAttempt")]
    public class UserExamAttempt
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Exam")]
        public int ExamId { get; set; }
        public Exam Exam { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("LoginUser")]
        public int LoginUserId { get; set; }
        public LoginUser LoginUser { get; set; }
        
        [Key, Column(Order = 3)]
        public int Attempt { get; set; }  

        public int Marks { get; set; }
        public bool PassofFail { get; set; }
        public DateTime ExamDate { get; set; }
      

    }
}
