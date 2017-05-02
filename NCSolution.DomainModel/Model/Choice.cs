using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSolution.DomainModel.Model
{
    [Table("Choice")]
    public class Choice
    {
        [Key]
        public int ChoiceId { get; set; }
        public string ChoiceString { get; set; }
        public int Order { get; set; }
        public bool IsJumble { get; set; }
        public bool CorrentOrWrong { get; set; }

        

        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
