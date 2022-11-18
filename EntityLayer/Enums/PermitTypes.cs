using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enums
{
    public enum PermitTypes
    {
        [Display(Name ="Mazaret İzini")]
        MazeretIzini = 1,
        [Display(Name = "Yıllık Ücretli İzin")]
        YıllıkUcretliIzin = 3,
        [Display(Name = "Sosyal İzin")]
        SosyalIzinler = 5,
        [Display(Name = "Süt İzini")]
        SutIzni = 7,
        [Display(Name = "Doğum Sonrası Ücretsiz İzin")]
        DogumSonrasiUcretsizIzin = 9,
        [Display(Name = "Emzirme İzini")]
        EmzirmeIzni = 11,
        [Display(Name = "Babalık İzini")]
        BabalikIzni = 13,
        [Display(Name = "Evlilik İzini")]
        EvlilikIzni = 15,


    }
}
