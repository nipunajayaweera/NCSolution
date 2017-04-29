using NCSolution.DataAccessLayer.Common;
using NCSolution.DataAccessLayer.Interface;
using NCSolution.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NCSolution.DataAccessLayer.Repository
{
    public class LoginUserRepository : GenericRepository<LoginUser>, ILoginUserRepository
    {

        
        public LoginUserRepository(DbContext context) : base(context)
        {
        }

        public LoginUser GetUserByUserName(string loginUserName)
        {
            LoginUser user = _dbset.Where(o => o.LoginUserName.Equals(loginUserName)).First();
            return user != null ? user : null;
        }
    }
}
