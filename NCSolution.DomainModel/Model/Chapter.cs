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
    [Table("Chapter")]
    public class Chapter : AuditableEntity<long>
    {
        [Key]
        public int ChapterId { get; set; }
        public string ChapterName { get; set; }
        public string ChapterDescription { get; set; }

        
        public virtual ICollection<ExamChapter> ExamChapters { get; set; }
        
        
    }
}
