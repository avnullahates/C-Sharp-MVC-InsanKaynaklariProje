using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enums
{
    public enum Approval
    {
        Onaylandı=1,
        [Display(Name ="Onay Bekliyor")]
        OnayBekliyor=3,
        Reddedildi=5
    }
}
