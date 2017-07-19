using NCSolution.BussinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCSolution.DomainModel.Model;
using NCSolution.DataAccessLayer.Common;
using NCSolution.DataAccessLayer.Interface;
using NCSolution.DomainModel.Dto;

namespace NCSolution.BussinessLayer.Contracts
{
    public class ExamService : IExamService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IExamRepository _examRepository;

        public ExamService (IUnitOfWork unitOfWork, IExamRepository examRepository)
        {
            _unitOfWork = unitOfWork;
            _examRepository = examRepository;
        }
        public IEnumerable<ExamDto> GetAllExamDetails()
        {
            return _examRepository.GetAllExamDetails();    
        }
    }
}
