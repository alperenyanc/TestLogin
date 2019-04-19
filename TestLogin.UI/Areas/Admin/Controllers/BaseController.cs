using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestLogin.BLL.Service;

namespace TestLogin.UI.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        // GET: Admin/Base
        protected EntityService service;
        public BaseController()
        {
            service = new EntityService();
        }
    }
}