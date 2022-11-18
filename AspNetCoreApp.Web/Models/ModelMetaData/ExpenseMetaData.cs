using CoreLayer.Enums;
using Microsoft.AspNetCore.Http;
using MusteriOrnegiCoreWeb.Models.Custom_Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreApp.Web.Models.ModelMetaData
{
    public class ExpenseMetaData
    {
        public int ID { get; set; }
        public bool Status { get; set; }

        [RegularExpression(@"^-?[0-9][0-9,\.]+$", ErrorMessage = "Lütfen sadece pozitif sayı giriniz.")]
        [Required(ErrorMessage = "Miktar girişi zorunludur.")]
        [SifirdanBuyukOlsun]        
        public decimal ExpenseAmount { get; set; }

        public IFormFile Invoce { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public Approval Approval { get; set; } = Approval.OnayBekliyor;

        [Required(ErrorMessage = "Ücreti tipini belirtiniz.")]
        public Currency Currency { get; set; }

        [Required(ErrorMessage = "Türünü belirtiniz.")]
        public TypeOfExpenses TypeOfExpenses { get; set; }

        [Required(ErrorMessage = "Açıklama giriniz.")]
        [MinLength(10, ErrorMessage = "Gider açıklaması minimum 10 karakter olmalıdır.")]
        public string Description { get; set; }

        public DateTime? ApprovalDate { get; set; }
    }
}
