using CoreLayer.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Models
{
    public class CompanyVM
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="(Şirket ismi girilmesi zorunludur!)")]

        public string Name { get; set; }
        public string Mail { get; set; }
       
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "(Şirket adresi girilmesi zorunludur!)")]
        [MaxLength(250,ErrorMessage ="(Adres açıklaması en fazla 250 karakter olabilir!)")]
        public string Address { get; set; }
        [Required(ErrorMessage = "(Şirket türü seçilmesi zorunludur!)")]
        public CompanyType CompanyType { get; set; }
        public IFormFile LogoPath { get; set; }
    }
}
