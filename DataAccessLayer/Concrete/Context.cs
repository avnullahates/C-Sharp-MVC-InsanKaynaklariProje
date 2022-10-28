using CoreLayer.Entities;
using DataAccessLayer.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        } 
        
        public DbSet<Advance> Advances { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonnelMapping()).ApplyConfiguration(new AdvanceMapping()).ApplyConfiguration(new DepartmentMapping());
        }
    }
}
