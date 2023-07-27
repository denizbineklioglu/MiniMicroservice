using System.ComponentModel.DataAnnotations;

namespace Demo.MVC.Models.User
{
    public class UserRegisterModel
    {
        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }

        [Display(Name = "Ad")]
        public string FirstName { get; set; }

        [Display(Name = "Soyad")]
        public string LastName { get; set; }

        public string Email { get; set; }

        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrarı")]
        public string ConfirmPassword { get; set; }
    }
}
