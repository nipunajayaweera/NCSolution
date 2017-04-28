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
    [Table("ExamChapter")]
    public class ExamChapter : AuditableEntity<long>
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Exam")]
        public int ExamId { get; set; }
        public Exam Exam { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Chapter")]
        public int ChapterId { get; set; }
        public Chapter Chapter { get; set; }

        public int NumberOfQuestionsFromChapter { get; set; }

    }
}
