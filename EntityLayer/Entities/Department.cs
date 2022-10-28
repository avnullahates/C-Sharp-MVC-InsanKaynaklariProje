using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Entities
{
    public class Department : BaseEntity
    {
        public ICollection<Personnel> Personnel { get; set; }
    }
}
