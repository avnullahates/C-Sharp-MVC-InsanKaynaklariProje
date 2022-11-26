using CoreLayer.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace AspNetCoreApp.Web.Models
{
    public class ManagerWithRole
    {
        public IdentityRole IdentityRole { get; set; }

         public List<Personnel> Personnels { get; set; }
    }
}
