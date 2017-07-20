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
using System.Data.SqlClient;
using System.Data;

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

        public IEnumerable<ExamChapterDto> GetChapters(int examId)
        {
            var parm = new SqlParameter("@examId", SqlDbType.Int);
            parm.Value = examId;
            //error
            return _entities.Database.SqlQuery<ExamChapterDto>("GetChapterByExam {0}",parm).ToList<ExamChapterDto>();

        }
    }
}
