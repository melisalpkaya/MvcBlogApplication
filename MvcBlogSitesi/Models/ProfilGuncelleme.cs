using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBlogSitesi.Models
{
    public class ProfilGuncelleme
    {
        
        public string Id { get; set; }
        
        [Required]
        [DisplayName("Adı")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Soyadı")]
        public string Surname { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }
        [Required]
        [DisplayName("Mail Adresi")]
        [EmailAddress(ErrorMessage ="Geçerli bir mail adresi giriniz!")]
        public string Email { get; set; }
    }
}