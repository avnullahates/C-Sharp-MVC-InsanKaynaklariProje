using AspNetCoreApp.Web.Models.ModelMetaData;
using CoreLayer.Entities;
using CoreLayer.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusteriOrnegiCoreWeb.Models.Custom_Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreApp.Web.Models
{
    [ModelMetadataType(typeof(ExpenseMetaData))]
    public class ExpenseDTO
    {
        public int ID { get; set; }
        public bool Status { get; set; }

    

        public decimal ExpenseAmount { get; set; }
        public IFormFile Invoce { get; set; }

   
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public Approval Approval { get; set; } = Approval.OnayBekliyor;


        public Currency Currency { get; set; }

   
        public TypeOfExpenses TypeOfExpenses { get; set; }

 
        public string Description { get; set; }

        public DateTime? ApprovalDate { get; set; }

        public string PersonnelID { get; set; }

        //public static implicit operator ExpenseDTO(ExpenseDTO v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
