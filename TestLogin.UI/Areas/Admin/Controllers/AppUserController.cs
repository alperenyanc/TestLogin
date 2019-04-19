using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestLogin.DAL.ORM.Entity;

namespace TestLogin.UI.Areas.Admin.Controllers
{
    public class AppUserController : BaseController
    {
        // GET: Admin/AppUser
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AppUser data)
        {
            AppUser user = service.AppUserService.FindByUserName(data.UserName);
            if (user is null)
            {
                service.AppUserService.Add(data);
            }
            else
            {
                return View();
            }
            
            return Redirect("/Admin/Home/Index");
        }
    }
}