using CoreLayer.Enums;
using Microsoft.AspNetCore.Mvc;
using MusteriOrnegiCoreWeb.Models.Custom_Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoreLayer.Entities
{
    [ModelMetadataType(typeof(ExpenseMetaData))]
    public class Expense : IBaseEntity
    {
        public int ID { get; set; }
        public bool Status { get; set ; }
        [Display(Name ="Harcama Tutarı")]
        public decimal ExpenseAmount { get; set; }
        
        public string Invoce { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public Approval Approval { get; set; } = Approval.OnayBekliyor;

 
        public Currency Currency { get; set; }

        [Display(Name = "Harcama Türü")]
        public TypeOfExpenses TypeOfExpenses { get; set; }

        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        public DateTime? ApprovalDate { get; set; }

        [Display(Name = "Yönetici Açıklaması")]
        public string ManagerDescription { get; set; }


        //Navigation propert

        public string PersonnelID { get; set; }
        public Personnel personnel { get; set; }
    }
}
