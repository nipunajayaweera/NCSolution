using NCSolution.BussinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCSolution.DomainModel.Model;
using NCSolution.DataAccessLayer.Common;
using NCSolution.DataAccessLayer.Interface;


namespace NCSolution.BussinessLayer.Contracts
{
    public class LoginUserService  : ILoginUserService 
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoginUserRepository _loginUserRepository;
                  
        public LoginUserService(IUnitOfWork unitOfWork, ILoginUserRepository loginUserRepository) 
        {
            _unitOfWork = unitOfWork;
            _loginUserRepository = loginUserRepository;
        }

        public LoginUser GetUserByUserName(string loginUserName)
        {
            return _loginUserRepository.GetUserByUserName(loginUserName);
        }


        public  IEnumerable<LoginUser> GetAll()
        {
            return _loginUserRepository.GetAll();
        }





    }
}
