using System.ComponentModel.DataAnnotations;

namespace Demo.MVC.Models.User
{
    public class UserLoginModel
    {
        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }

        [Display(Name ="Şifre")]
        public string Password { get; set; }
    }
}
