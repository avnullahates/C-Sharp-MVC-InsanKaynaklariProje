using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enums
{
    public enum PermitTypeMale
    {
        [Display(Name = "Yıllık Ücretli İzin")]
        YillikUcretliIzin,
        [Display(Name = "Askerlik İzni")]
        AskerlikIzni,
        [Display(Name = "Haftalık Tatil İzni")]
        HaftalikTatilIzni,
        [Display(Name = "Yeni İş Arama İzni")]
        YeniIsAramaIzni,
        [Display(Name = "Mazaret İzinleri")]
        MazeretIzinleri,
        [Display(Name = "Hastalık Ve İstirahat İzni")]
        HastalikVeIstihrahatIzni,
    }
}
