using CoreLayer.Entities;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace AspNetCoreApp.Web.Models
{
    public class PersonnelVM
    {
     
        public string Id { get; set; }

        public string PhoneNumber { get; set; }

        public IFormFile ImagePath { get; set; }
      
  
        public string Address { get; set; }
    
    
    }
}
