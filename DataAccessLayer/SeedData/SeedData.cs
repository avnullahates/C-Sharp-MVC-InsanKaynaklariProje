using CoreLayer.Entities;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CoreLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.SeedData
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            //using (var serviceScope = app.ApplicationServices.CreateScope())
            //{
            //    Context context = serviceScope.ServiceProvider.GetService<Context>();
            //    context.Database.Migrate();

            //    if (!context.Personnels.Any())
            //    {
            //        context.Personnels.AddRange(
            //        new Personnel() { Name = "Buse", Surname = "Duran", BirthDate = new DateTime(1996, 04, 03), IdentityNumber = "12345678901", PlaceOfBirth = "İzmir", HireDate = new DateTime(2020, 04, 03), Job = "Mühendis", Email = "busis@gmail.com", Gender = Gender.Female },
            //        new Personnel() { Name = "Hasan", MiddleName = "Furkan", Surname = "Kesgin", BirthDate = new DateTime(1997, 04, 04), IdentityNumber = "12345678925", PlaceOfBirth = "İstanbul", HireDate = new DateTime(2020, 05, 03), Job = "Mühendis", Email = "furkan@gmail.com", Gender = Gender.Male },
            //        new Personnel() { Name = "Nuray", Surname = "Marhan", BirthDate = new DateTime(1996, 04, 03), IdentityNumber = "12345678930", PlaceOfBirth = "İstanbul", HireDate = new DateTime(2020, 04, 03), Job = "Yazılım", Email = "nuray@gmail.com", Gender = Gender.Female }
            //        );
            //    }

            //    context.SaveChanges();

            //}
        }

    }
}
