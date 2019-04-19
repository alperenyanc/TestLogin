using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TestLogin.DAL.ORM.Entity;
using TestLogin.UI.Areas.Admin.Models.LoginVM;

namespace TestLogin.UI.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        // GET: Admin/Account
        public ActionResult Login()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return Redirect("/Admin/Home/Index");
            }
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Login(LoginVm credential)
        {
            if (ModelState.IsValid)
            {
                if (service.AppUserService.CheckCredentials(credential.UserName, credential.Password))
                {
                    AppUser user = service.AppUserService.FindByUserName(credential.UserName);

                    string cookie = user.UserName;
                    FormsAuthentication.SetAuthCookie(cookie, true);
                    //return Redirect("/Admin/Home/Index");
                    if (user.Role == TestLogin.DAL.ORM.Enum.Role.Admin)
                    {
                        return Redirect("/Admin/Home/Index");
                    }
                    else if (user.Role == DAL.ORM.Enum.Role.Member)
                    {
                        return Redirect("/Admin/Home/Member");
                    }
                    else
                    {
                        return View();
                    }

                }
                else
                {
                    ViewData["error"] = "Kullanıcı adı veya şifre Hatalı";
                    return View();
                }
            }
           
            return View();
        }
    }
}