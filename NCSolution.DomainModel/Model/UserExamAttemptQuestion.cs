using NCSolution.DomainModel.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSolution.DomainModel.Model
{
    [Table("UserExamAttemptQuestion")]
    public class UserExamAttemptQuestion  : AuditableEntity<long>
    {
        [Key, Column(Order = 0)]
        [ForeignKey("UserExamAttempt")]
        public int ExamId { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("UserExamAttempt")]
        public int LoginUserId { get; set; }

        [Key, Column(Order = 2)]
        [ ForeignKey("UserExamAttempt")]
        public int Attempt { get; set; }
        
        public UserExamAttempt UserExamAttempt { get; set; }



        [Key, Column(Order = 3)]
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }


        public int ChoiceId { get; set; }



    }
}
