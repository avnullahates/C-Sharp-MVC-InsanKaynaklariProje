using CoreLayer.CustomValidation;
using CoreLayer.Enums;
using MusteriOrnegiCoreWeb.Models.Custom_Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Entities
{
    public class Permit : IBaseEntity
    {
        public int ID { get; set; }

        public bool Status { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Başlangıç tarihi zorunludur")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);

        
        [DataType(DataType.Date)]
        public DateTime RequestDate { get; set; }

        public int PermitDay { get; set; }

        public Approval Approval { get; set; } = Approval.OnayBekliyor;

        public PermitTypes PermitTypes { get; set; }

        [Required(ErrorMessage = "Açıklama giriniz.")]
        [MinLength(10, ErrorMessage = "Avans açıklaması minimum 10 karakter olmalıdır.")]
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        public DateTime? ApprovalDate { get; set; }

        [Display(Name = "Yönetici Açıklaması")]
        public string ManagerDescription { get; set; }

        public string PersonnelID { get; set; }
        public Personnel Personnel { get; set; }
        
    }
}
