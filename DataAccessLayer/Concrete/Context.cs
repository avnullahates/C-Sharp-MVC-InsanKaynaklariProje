using CoreLayer.Entities;
using DataAccessLayer.Mappings;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<Personnel>
    {
       
        
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Advance> Advances { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Permit> Permits { get; set; }
        public DbSet<Company> Companies { get; set; }

        public DbSet<Expense> Expenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonnelMapping()).ApplyConfiguration(new AdvanceMapping()).ApplyConfiguration(new DepartmentMapping()).ApplyConfiguration(new ExpenseMapping()).ApplyConfiguration(new ManagerMapping()).ApplyConfiguration(new PermitMapping()).ApplyConfiguration(new CompanyMapping());

            base.OnModelCreating(modelBuilder);


        }
    }
}
