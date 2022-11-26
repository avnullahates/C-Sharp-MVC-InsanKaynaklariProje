using CoreLayer.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Entities
{
    public class Company : IBaseEntity
    {
        
        public int ID { get; set; }
        //[Required(ErrorMessage = "Şirket ismi zorunludur!")]
        [Display(Name = "Şirket Adı")]
        public string Name { get; set; }
        //[Required(ErrorMessage = "Şirket telefonu zorunludur!")]
        [Display(Name = "Şirket Telefonu")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Şirket Adresi")]
        public string Address { get; set; }
        //[Required(ErrorMessage = "Şirket maili zorunludur!")]
        [Display(Name = "Şirket Maili")]
        public string Mail { get; set; }
        [Display(Name = "Şirket Logosu")]
        public string LogoPath { get; set; }
        [Display(Name = "Şirket Personel Sayısı")]
        public int PersonnelAmount { get; set; }
        //[Required(ErrorMessage = "Şirket ismi zorunludur!")]
        [Display(Name = "Şirket Türü")]
        public CompanyType CompanyType { get; set; }
        public bool Status { get; set; }
        public List<Personnel> Personnels { get; set; }
        public List<Manager> Managers { get; set; }
        
    }
}
