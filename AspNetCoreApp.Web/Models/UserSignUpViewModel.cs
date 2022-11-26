using CoreLayer.Entities;
using CoreLayer.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "(Lütfen adınızı giriniz!)"), MinLength(2, ErrorMessage = "(Ad 2 karakterden az olamaz)")]
        public string Name { get; set; }

        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "(Lütfen soyadınızı giriniz!)"), MinLength(2, ErrorMessage = "(Soyad 2 karakterden az olamaz)")]
        public string Surname { get; set; }



        public string UserName { get; set; }

        [Display(Name = "İkinci Ad")]
        public string MiddleName { get; set; }

        [Display(Name = "İkinci Soyad")]
        public string SecondSurname { get; set; }

        [Required(ErrorMessage = "(Doğum tarihi girişi zorunludur!)")]
        [Display(Name = "Doğum Tarihi")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "(TC Kimlik No girişi zorunludur!)"), StringLength(11, ErrorMessage = "(TC Kimlik No 11 karakter olmalıdır!)")]
        [Display(Name = "TC Kimlik No")]
        public string IdentityNumber { get; set; }

        [Required(ErrorMessage = "(Doğum Yeri girişi zorunludur!)")]
        [Display(Name = "Doğum Yeri")]
        public string PlaceOfBirth { get; set; }

        [Required(ErrorMessage = "(İşe Giriş Tarihi zorunludur!)")]
        [Display(Name = "İşe Giriş Tarihi")]
        public DateTime HireDate { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Telefon Numarası")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "(Meslek girişi zorunludur!)")]
        [Display(Name = "Meslek")]
        public string Job { get; set; }

        [Display(Name = "Adres")]
        [Required(ErrorMessage = "(Adres girişi zorunludur!)")]
        public string Address { get; set; }

        public decimal Salary { get; set; }



        public bool? IsActive { get; set; }

        [Display(Name = "Cinsiyet")]
        public Gender Gender { get; set; }

        [Display(Name = "Departman Türü")]
        public int DepartmentID { get; set; }

        public List<Department>Departments { get; set; }

        public int CompanyID { get; set; }
        public List<Company> Companies { get; set; }
        public List<Personnel> Personnels { get; set; }

        public IdentityRole IdentityRole { get; set; }

    }
}
