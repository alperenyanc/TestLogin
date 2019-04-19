using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLogin.DAL.ORM.Entity;

namespace TestLogin.DAL.ORM.Map
{
    public class AppUserMap : BaseMap<AppUser>
    {
        public AppUserMap()
        {
            Property(x => x.UserName).IsRequired();
            Property(a => a.Password).IsRequired();
            Property(a => a.Role).IsRequired();

        }
    }
}
