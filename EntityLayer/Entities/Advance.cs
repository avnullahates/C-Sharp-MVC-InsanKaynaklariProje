using CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Entities
{
   
    public class Advance : BaseEntity
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public decimal AdvanceAmount { get; set; }
        public Approval Approval { get; set; }
        public Currency Currency { get; set; }

        public string Description { get; set; }

        public DateTime ApprovalDate { get; set; }

        [ForeignKey("Personnel")]
        public int PersonnelID { get; set; }
        public Personnel Personnel { get; set; }
    }
}
