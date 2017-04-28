using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSolution.DomainModel.Model
{
    [Table("Image")]
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        public string Url { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        public  Question Question { get; set; }
    }
}
