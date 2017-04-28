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
    [Table("Question")]
    public class Question : AuditableEntity<long>
    {

        [Key]
        public int QuestionId { get; set; }

        public string QuestionContent { get; set; }
        public string Explantion { get; set; }
        public int NumberOfChoices { get; set; }
        public int Priority { get; set; }
        public bool CanRandomizeChoices { get; set; }
        public int DifficultyLevel { get; set; }
        public string Language { get; set; }
        public string Tag { get; set; }


        [ForeignKey("Chapter")]
        public int ChapterId { get; set; }
        public  Chapter Chapter { get; set; }

        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Choice> Choices { get; set; }
        public virtual ICollection<UserExamAttemptQuestion> UserExamAttemptQuestionAnswer { get; set; }





    }
}
