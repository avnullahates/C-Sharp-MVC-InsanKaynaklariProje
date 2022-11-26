using CoreLayer.Entities;
using System.Collections.Generic;

namespace AspNetCoreApp.Web.Models
{
    public class CompanyWithManager
    {
        public List<Company> Companies { get; set; }

        public List<Personnel> Personnels { get; set; }

        public List<Department> Departments { get; set; }
    }
}
