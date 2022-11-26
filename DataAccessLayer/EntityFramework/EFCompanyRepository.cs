using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCompanyRepository : GenericRepository<Company>, ICompanyDal
    {
        private readonly Context _dbContext;

        public EFCompanyRepository(Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Company GetAllPersonelsWithCompany(int id)
        {
            return _dbContext.Companies.Include(a => a.Personnels).FirstOrDefault(a => a.ID == id);
        }
    }
}
