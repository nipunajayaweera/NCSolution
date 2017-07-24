using NCSolution.DataAccessLayer.Common;
using NCSolution.DataAccessLayer.Interface;
using NCSolution.DomainModel.Dto;
using NCSolution.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSolution.DataAccessLayer.Repository
{
    public class AdminRepository: GenericRepository<Question>, IAdminRepository
    {
        public AdminRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<QuestionDto> AllQuestions()
        {
            return _entities.Database.SqlQuery<QuestionDto>("").ToList<QuestionDto>();
        }
        
    }
}
