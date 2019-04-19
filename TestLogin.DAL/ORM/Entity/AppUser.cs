using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLogin.DAL.ORM.Enum;

namespace TestLogin.DAL.ORM.Entity
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
