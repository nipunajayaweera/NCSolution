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
    [Table("Exam")]
    public class Exam : AuditableEntity<long>
    {
        [Key]
        public int ExamId { get; set; }
        public string ExamDescription { get; set; }
        public  new DateTime CreatedDate { get; set; }
        public int TotalQuestions { get; set; }
        public bool IsActive { get; set; }


        [JsonIgnore]
        public virtual ICollection<UserExamAttempt> UserExamAttempts { get; set; }

        public virtual ICollection<ExamChapter> ExamChapters { get; set; }



    }
}
