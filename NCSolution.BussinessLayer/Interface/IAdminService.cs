using NCSolution.DomainModel.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSolution.BussinessLayer.Interface
{
    public interface IAdminService
    {
        IEnumerable<QuestionDto> AllQuestions();
    }
}
