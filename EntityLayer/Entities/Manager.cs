using CoreLayer.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Entities
{
    public class Manager : IdentityUser, IBaseEntity
    {
        public bool Status { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
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
        public string Address { get; set; }
        //public string Company { get; set; }
        public decimal? Salary { get; set; }
        public Gender Gender { get; set; }
        public bool? IsActive { get; set; }

        // Nav - Prop
        public int? DepartmentID { get; set; }
        public Department Department { get; set; }
        public List<Advance> Advances { get; set; }

        public List<Expense> Expenses { get; set; }

        public List<Permit> Permits { get; set; }
    }
}
