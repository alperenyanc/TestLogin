using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestLogin.UI.Areas.Admin.Models.LoginVM
{
    public class LoginVm
    {
        
            [Required(ErrorMessage = "Kulanıcı Adı Hatası!")]
            public string UserName { get; set; }

            [Required(ErrorMessage = "Şifre Hatası!")]
            public string Password { get; set; }
        
    }
}