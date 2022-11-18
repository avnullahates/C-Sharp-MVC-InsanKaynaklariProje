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
    public class PermitMapping : IEntityTypeConfiguration<Permit>
    {
        public void Configure(EntityTypeBuilder<Permit> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();


            builder.HasOne(a => a.Personnel).WithMany(a => a.Permits).HasForeignKey(a => a.PersonnelID);
        }
    }
}
