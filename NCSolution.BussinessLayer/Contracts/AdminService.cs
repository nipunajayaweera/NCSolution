using NCSolution.BussinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCSolution.DomainModel.Dto;
using NCSolution.DataAccessLayer.Common;
using NCSolution.DataAccessLayer.Interface;

namespace NCSolution.BussinessLayer.Contracts
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAdminRepository _adminRepository;

        public IEnumerable<QuestionDto> AllQuestions()
        {
            return _adminRepository.AllQuestions();
        }
    }
}
