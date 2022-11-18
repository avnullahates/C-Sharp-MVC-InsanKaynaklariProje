using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Models
{
    public class PermissionEmployeeVM
    {
        public Permit Permit { get; set; }
        public Personnel Personnel { get; set; }
    }
}
