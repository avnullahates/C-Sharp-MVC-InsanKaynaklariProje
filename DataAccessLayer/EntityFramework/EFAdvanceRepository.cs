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
    public class EFAdvanceRepository : GenericRepository<Advance>, IAdvanceDal
    {
        private readonly Context _dbContext;

        public EFAdvanceRepository(Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Advance> GetListAllAdvance(string id)
        {
            return _dbContext.Advances.Include(x => x.Personnel).Where(a=>a.PersonnelID == id).ToList();
        }
    }
}
