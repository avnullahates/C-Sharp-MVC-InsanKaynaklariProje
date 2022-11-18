using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Entities
{
    public class Department : IBaseEntity
    {
        public int ID { get; set; }
        public bool Status { get; set; }
        public List<Personnel> Personnels { get; set; }
        public List<Manager> Managers { get; set; }
        public string DepartmentName { get; set; }
    }
}
