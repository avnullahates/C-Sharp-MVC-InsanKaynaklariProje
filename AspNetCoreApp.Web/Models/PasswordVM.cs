using CoreLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreApp.Web.Models
{
    public class PasswordVM
    {
        public string Email { get; set; }
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Lütfen parolanızı girin"), MinLength(6, ErrorMessage = "Parola 6 karakterden az olamaz!")]
        public string NewPassword { get; set; }

        public string ConfirmPassword { get; set; }

       
    }
}
