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
    public class AdvanceMapping : IEntityTypeConfiguration<Advance>
    {
        public void Configure(EntityTypeBuilder<Advance> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();

            builder.Property(x => x.AdvanceAmount).IsRequired();

            builder.Property(x => x.Description).IsRequired();

            builder.Property(x => x.ApprovalDate).IsRequired();

        }
    }
}
