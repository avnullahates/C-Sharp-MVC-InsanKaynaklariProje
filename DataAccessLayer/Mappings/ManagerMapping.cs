﻿using CoreLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings
{
    public class ManagerMapping : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
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

            builder.HasOne(a => a.Department).WithMany(a => a.Managers).HasForeignKey(a => a.DepartmentID);
        }
    }
}
