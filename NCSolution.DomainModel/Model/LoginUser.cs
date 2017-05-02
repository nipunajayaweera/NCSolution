using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NCSolution.DomainModel.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace NCSolution.DomainModel.Model
{
    [Table("LoginUser")]
    public class LoginUser: AuditableEntity<long>
    {
        [Key]
        public int LoginUserId { get; set; }
        public string Email { get; set; }  
        public string LoginUserName { get; set; }
        public int PhoneNumber { get; set; }


        [JsonIgnore]
        public virtual ICollection<UserExamAttempt> UserExamAttempts { get; set; }




    }
}
