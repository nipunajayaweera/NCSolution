using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCSolution.Models
{
    class UserViewModel
    {
    }
    public class LoginUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }

    }

    public class RegisterUser
    {
        public string Name { get; set; }
        public string NIC { get; set; }

    }
}
