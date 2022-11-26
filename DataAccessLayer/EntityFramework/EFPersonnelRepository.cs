using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFPersonnelRepository : GenericRepository<Personnel>, IPersonnelDal
    {
        private readonly Context dbContext;

        public EFPersonnelRepository(Context dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Personnel> GetAllPersonelsWithDepartmentFilter(Expression<Func<Personnel, bool>> exp)
        {
            return dbContext.Personnels.Include(a=>a.Department).Where(exp).ToList();
        }

        public List<Personnel> GetAllPersonelsWithDepartment()
        {
            return dbContext.Personnels.Include(a => a.Department).ToList();
        }

        


    }
}
