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
    public class CompanyMapping : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.ID).IsRequired();
            builder.Property(x => x.Name).IsUnicode(true).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Address).IsUnicode(true).HasMaxLength(250);
            builder.Property(x => x.Mail).IsRequired();
            builder.Property(x => x.PersonnelAmount).IsRequired();
            builder.Property(x => x.CompanyType).IsRequired();

        }
    }
}
