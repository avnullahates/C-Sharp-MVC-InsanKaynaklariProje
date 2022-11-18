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
    public class ExpenseMapping:IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
           
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired();

            builder.Property(x => x.ExpenseAmount).IsRequired();

            builder.Property(x => x.Description).IsRequired();

            builder.HasOne(a=>a.personnel).WithMany(a=>a.Expenses).HasForeignKey(a=>a.PersonnelID);
        }
    }

    
}
