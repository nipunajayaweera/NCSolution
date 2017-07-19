using NCSolution.DataAccessLayer.Common;
using NCSolution.DataAccessLayer.Interface;
using NCSolution.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NCSolution.DomainModel.Dto;

namespace NCSolution.DataAccessLayer.Repository
{
    public class ExamRepository : GenericRepository<Exam>, IExamRepository
    {
        public ExamRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<ExamDto> GetAllExamDetails()
        {
            return _entities.Database.SqlQuery<ExamDto>("GetAllExams").ToList<ExamDto>();
        }
    }
}
