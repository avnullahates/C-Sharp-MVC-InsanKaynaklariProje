using AspNetCoreApp.Web.Models.ModelMetaData;
using CoreLayer.Entities;
using CoreLayer.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApp.Web.Models
{
    [ModelMetadataType(typeof(PermitMetaData))]
    public class PermitDTO
    {
        public int ID { get; set; }

        public bool Status { get; set; }

       
        public DateTime StartDate { get; set; }

        
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);


        public DateTime RequestDate { get; set; } = DateTime.Now;

        
        public int? PermitDay { get; set; }

        public Approval Approval { get; set; } = Approval.OnayBekliyor;

        public PermitTypes PermitTypes { get; set; }


        public string Description { get; set; }

      
        public DateTime? ApprovalDate { get; set; }

        public string PersonnelID { get; set; }
        public Personnel Personnel { get; set; }

    }
}
