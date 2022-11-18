using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad")]
        [Required(ErrorMessage ="Lütfen adınızı giriniz!"),MinLength(2,ErrorMessage ="Ad 2 karakterden az olamaz")]
        public string Name { get; set; }
        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz!"), MinLength(2, ErrorMessage = "Soyad 2 karakterden az olamaz")]
        public string Surname { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen şifre giriniz!")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz!")]
        [EmailAddress(ErrorMessage ="Mail adresinizi doğru formatta giriniz!")]
        public string Mail { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz!")]
        public string UserName { get; set; }

       
        public string MiddleName { get; set; }
       
        public string SecondSurname { get; set; }

        public DateTime BirthDate { get; set; }
        public string IdentityNumber { get; set; }
      
        public string PlaceOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Job { get; set; }
        //public string Password { get; set; }
        public string Address { get; set; }
        //public string Company { get; set; }
        public decimal Salary { get; set; }
      
        public bool? IsActive { get; set; }

        public int DepartmentID { get; set; }
    }
}
