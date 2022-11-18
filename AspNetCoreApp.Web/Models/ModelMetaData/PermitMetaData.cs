using CoreLayer.CustomValidation;
using CoreLayer.Entities;
using CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Models.ModelMetaData
{
    public class PermitMetaData
    {
        public int ID { get; set; }

        public bool Status { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Başlangıç tarihi zorunludur")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Bitiş tarihi zorunludur")]
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime RequestDate { get; set; }

       
        public int? PermitDay { get; set; }

        
        public Approval Approval { get; set; } = Approval.OnayBekliyor;

        [Required(ErrorMessage = "Türünü belirtiniz.")]
        public PermitTypes PermitTypes { get; set; }

        [Required(ErrorMessage = "Açıklama giriniz.")]
        [MinLength(10, ErrorMessage = "Gider açıklaması minimum 10 karakter olmalıdır.")]
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = false)]
        public DateTime? ApprovalDate { get; set; }

       
    }
}
