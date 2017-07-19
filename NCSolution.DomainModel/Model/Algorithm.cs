using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSolution.DomainModel.Model
{
    public class Algorithm
    {
        [Key]
        public int AlgorithmId { get; set; }
        public string AlgorithmName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
    }
}
