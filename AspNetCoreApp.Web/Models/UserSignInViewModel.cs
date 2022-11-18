using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Models
{
    public class UserSignInViewModel
    {
        [EmailAddress(ErrorMessage ="E-mail formatına uygun olmalıdır!"),Required(ErrorMessage ="E-mail girişi zorunludur.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Lütfen parolanızı girin"),MinLength(6,ErrorMessage ="Parola 6 karakterden az olamaz!")]
        public string password { get; set; }

    }
}
