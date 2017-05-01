using NCSolution.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSolution.BussinessLayer.Interface
{
    public interface ILoginUserService   
    {
        LoginUser GetUserByUserName(string loginUserName);
        IEnumerable<LoginUser> GetAll();
    }
}
