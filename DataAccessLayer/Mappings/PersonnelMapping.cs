using CoreLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings
{
    public class PersonnelMapping : IEntityTypeConfiguration<Personnel>
    {
        public void Configure(EntityTypeBuilder<Personnel> builder)
        {

            builder.Property(x => x.Name).IsUnicode(true).HasMaxLength(50).IsRequired();

            builder.Property(x => x.MiddleName).IsUnicode(true).HasMaxLength(50);

            builder.Property(x => x.Surname).IsUnicode(true).HasMaxLength(50).IsRequired();

            builder.Property(x => x.SecondSurname).IsUnicode(true).HasMaxLength(50);

            builder.Property(x => x.BirthDate).IsRequired();


            builder.Property(e => e.IdentityNumber)
                .HasMaxLength(11)
                .IsFixedLength()
                .IsUnicode(false) // Gereksiz yer kaplamasın diye hafıza
                .IsRequired();
            builder.HasIndex(e => e.IdentityNumber)
                .IsUnique().HasDatabaseName("INDX_Personnel_IdentityNumber");

            
            builder.Property(x => x.PlaceOfBirth).IsUnicode(true).HasMaxLength(50).IsRequired();

            builder.Property(x => x.HireDate).IsUnicode(true).IsRequired();

            builder.Property(x => x.Job).IsUnicode(true).HasMaxLength(100).IsRequired();

            


            //builder.Property(x => x.Password).IsRequired();

            builder.Property(x => x.Gender).IsRequired();

            builder.HasOne(a => a.Department).WithMany(a => a.Personnels).HasForeignKey(a => a.DepartmentID);

            //builder.HasOne(a => a.Company).WithMany(a => a.Personnels).HasForeignKey(a => a.CompanyID);

        }
    }
}
