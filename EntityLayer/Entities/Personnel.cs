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
        [Required(ErrorMessage ="Ad girişi zorunludur!")]
        public string Name { get; set; }
        [Display(Name = "İkinci Ad")]
        public string MiddleName { get; set; }
        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Soyad girişi zorunludur!")]
        public string Surname { get; set; }
        [Display(Name = "İkinci Soyad")]
        public string SecondSurname { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        [Display(Name = "Doğum Tarihi")]
        [Required(ErrorMessage ="Doğum tarihi girişi zorunludur!")]
        public DateTime BirthDate { get; set; }
        public string IdentityNumber { get; set; }
        public string ImagePath { get; set; }
        public string PlaceOfBirth { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        public DateTime HireDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        public DateTime? ReleaseDate { get; set; }
        public string Job { get; set; }
        //public string Password { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        //public string Company { get; set; }
        public decimal? Salary { get; set; }
        public Gender Gender { get; set; }
        public bool? IsActive { get; set; }

        // Nav - Prop
        public int? DepartmentID { get; set; }
        [Display(Name = "Departman")]
        public Department Department { get; set; }
        public List<Advance> Advances { get; set; }

        public List<Expense> Expenses { get; set; }

        public List<Permit> Permits { get; set; }

    }
}
