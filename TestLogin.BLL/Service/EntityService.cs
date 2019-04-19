using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLogin.BLL.Repository;

namespace TestLogin.BLL.Service
{
    public class EntityService
    {
        public EntityService()
        {
            _appUserService = new AppUserRepository();
        }

        private AppUserRepository _appUserService;
        public AppUserRepository AppUserService
        {
            get { return _appUserService; }
            set { _appUserService = value; }
        
        }
    }
}
