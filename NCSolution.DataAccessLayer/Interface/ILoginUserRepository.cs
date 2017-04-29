using NCSolution.DataAccessLayer.Common;
using NCSolution.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSolution.DataAccessLayer.Interface
{
    public interface ILoginUserRepository :IGenericRepository<LoginUser>
    {
        LoginUser GetUserByUserName(string loginUserName);

    }
}
