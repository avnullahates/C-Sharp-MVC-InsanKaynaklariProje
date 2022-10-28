using CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Entities
{
    
    public class Personnel : BaseEntity
    {
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public string SecondSurname { get; set; }

        public DateTime BirthDate { get; set; }
        public string IdentityNumber { get; set; }
        public string ImagePath { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Job { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        //public string Company { get; set; }
        public decimal? Salary { get; set; }
        public Gender Gender { get; set; }
        public bool? IsActive { get; set; }

        // Nav - Prop
        public int? DepartmentID { get; set; }
        public Department Department { get; set; }
        public int? AdvanceID { get; set; }
        public Advance Advance { get; set; }

    }
}
