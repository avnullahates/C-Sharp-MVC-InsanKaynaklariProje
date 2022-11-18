using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.VM
{
    public class PersonnelPermitVM
    {
        public Permit Permit { get; set; }
        public List<Personnel> Personnels { get; set; }
    }
}
