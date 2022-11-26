using CoreLayer.Enums;
using Microsoft.AspNetCore.Identity;
using MusteriOrnegiCoreWeb.Models.Custom_Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Entities
{
   
    public class Advance : IBaseEntity
    {
        public int ID { get; set; }
        public bool Status { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        [RegularExpression("[0-9]+", ErrorMessage = "Lütfen pozitif sayı giriniz")]
        [Required(ErrorMessage = "Miktar girişi zorunludur.")]
        [SifirdanBuyukOlsun]
        public decimal AdvanceAmount { get; set; }
       
        public Approval Approval { get; set; } = Approval.OnayBekliyor;

        [Required(ErrorMessage = "Ücreti tipini belirtiniz.")]
        public Currency Currency { get; set; }

        [Required(ErrorMessage = "Açıklama giriniz.")]
        [MinLength(10, ErrorMessage= "Avans açıklaması minimum 10 karakter olmalıdır.")]
       
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        public DateTime? ApprovalDate { get; set; }

        [Display(Name = "Yönetici Açıklaması")]
        public string ManagerDescription { get; set; }


        public string PersonnelID { get; set; }
        public Personnel Personnel { get; set; }

        
    }
}
