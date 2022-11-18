using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.CustomValidation
{
   public class SifirdanBuyukOlsunInt : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            int deger = (int)value;


            if (deger > 999999)
            {
                return new ValidationResult("Geçerli gider girin!");
            }
            if (deger == 0)
            {
                return new ValidationResult("Değer sıfıra eşit olamaz");
            }
            if (deger < 0)
            {
                return new ValidationResult("Değer sıfırdan küçük olamaz");
            }
            return ValidationResult.Success;
        }
    }
}
