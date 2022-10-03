using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBlogSitesi.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Soyadınız")]
        public string Surname { get; set; }
        [Required]
        [DisplayName("Kullanıcı adı")]
        public string Username { get; set; }
        [Required]
        [DisplayName("Mail adresi")]
        [EmailAddress(ErrorMessage ="Geçersiz e-posta adresi")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }
        [Required]
        [DisplayName("Şifre Tekrarı")]
        [Compare("Password",ErrorMessage ="Şifreler aynı değil!")]
        public string RePassword { get; set; }
    }
}