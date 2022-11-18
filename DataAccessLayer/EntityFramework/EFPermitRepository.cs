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
    public class EFPermitRepository : GenericRepository<Permit>, IPermitDal
    {
        private readonly Context dbContext;

        public EFPermitRepository(Context dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Permit> GetListAllPermit(string id)
        {
            return dbContext.Permits.Include(a => a.Personnel).Where(a => a.PersonnelID == id).ToList();
        }
    }
}
