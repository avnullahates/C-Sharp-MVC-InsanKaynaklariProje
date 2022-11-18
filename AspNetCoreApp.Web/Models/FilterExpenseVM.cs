using CoreLayer.Entities;
using CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreApp.Web.Models
{
    public class FilterExpenseVM
    {
        [Required(ErrorMessage ="Gider türü seçilmelidir!")]
        public TypeOfExpenses TypeOfExpenses { get; set; }

   
        public List<Expense> Expenses { get; set; }


    }
}
