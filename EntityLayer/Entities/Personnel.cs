using CoreLayer.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Entities
{

    public class Personnel : IdentityUser, IBaseEntity
    {
        public bool Status { get; set; }
        [Display(Name ="Ad")]
        [Required(ErrorMessage ="(Ad girişi zorunludur!)")]
        [MinLength(2,ErrorMessage ="(Ad minimum 2 karakter olabilir!)")]
        public string Name { get; set; }

        [Display(Name = "İkinci Ad")]
        public string MiddleName { get; set; }
        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "(Soyad girişi zorunludur!)")]
        [MinLength(2, ErrorMessage = "(Soyad minimum 2 karakter olabilir!)")]
        public string Surname { get; set; }

        [Display(Name = "İkinci Soyad")]
        public string SecondSurname { get; set; }

        //[DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        [Display(Name = "Doğum Tarihi")]
        [Required(ErrorMessage ="(Doğum tarihi girişi zorunludur!)")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Kimlik Numarası")]
        public string IdentityNumber { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Doğum Yeri")]
        public string PlaceOfBirth { get; set; }
        //[DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]

        [Display(Name = "İşe Giriş Tarihi")]
        public DateTime HireDate { get; set; }
        //[DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        public DateTime? ReleaseDate { get; set; }
        [Display(Name = "Meslek")]
        public string Job { get; set; }
        //public string Password { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        //public string Company { get; set; }
        public decimal? Salary { get; set; }
        public Gender Gender { get; set; }
        public bool? IsActive { get; set; }

        

        // Nav - Prop
        [Display(Name ="Departman Türü")]
        public int? DepartmentID { get; set; }
        //[Display(Name = "Şirket Adı")]
        public int? CompanyID { get; set; }
        [Display(Name = "Departman")]
        //[Required(ErrorMessage ="(Departman seçimi zorunludur!)")]
        public Department Department { get; set; }

        //[Display(Name ="Şirket")]
        //[Required(ErrorMessage ="Şirket seçimi zorunludur!")]
        public Company Company { get; set; }
        public List<Advance> Advances { get; set; }

        public List<Expense> Expenses { get; set; }

        public List<Permit> Permits { get; set; }

        

    }
}
