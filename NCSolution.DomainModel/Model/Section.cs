using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSolution.DomainModel.Model
{
    public class Section
    {
        [Key]
        public int SectionId { get; set; }
        public string  SectionName { get; set; }


        [ForeignKey("Chapter")]
        public int ChapterId { get; set; }

        public Chapter Chapter { get; set; }


        public virtual ICollection<Question> Questions { get; set; }


    }
}
