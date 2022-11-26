using CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Models
{
    public class AdvanceVM
    {
        public string Id { get; set; }
        
        [RegularExpression("[0-9]+", ErrorMessage = "Lütfen pozitif tamsayı giriniz")]
        [Display(Name = "Avans Miktarı")]
        [Required(ErrorMessage = "Avans miktarı girişi zorunludur!")]
        public decimal AdvanceAmount { get; set; }


        [Display(Name = "Avans Açıklaması")]
        [Required(ErrorMessage = "Avans açıklaması girişi zorunludur!")]
        [MinLength(10,ErrorMessage ="Avans açıklaması en az 10 karakter olmalıdır!")]
        public string Description { get; set; }


        [Display(Name = "Para Birimi")]
        [Required(ErrorMessage = "Para birimi seçimi zorunludur!")]
        public Currency Currency { get; set; }

        public Approval Approval { get; set; }
    }
}
