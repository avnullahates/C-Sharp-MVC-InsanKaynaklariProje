using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CoreLayer.Entities;

namespace MusteriOrnegiCoreWeb.Models.Custom_Validation
{
    public class SifirdanBuyukOlsun : ValidationAttribute
    {
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            decimal deger = (decimal)value;

            if (deger==0)
            {
                return new ValidationResult("Değer sıfıra eşit olamaz");
            }
            if (deger <0)
            {
                return new ValidationResult("Değer sıfırdan küçük olamaz");
            }
          

            return ValidationResult.Success;
        }     
    }
}
