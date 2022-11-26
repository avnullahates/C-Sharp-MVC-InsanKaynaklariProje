using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enums
{
    public enum CompanyType
    {
        [Display(Name ="Limited Şirket")]
        LimitedSirket=1,
        [Display(Name = "Anonim Şirket")]
        AnonimSirket =2
    }
}
