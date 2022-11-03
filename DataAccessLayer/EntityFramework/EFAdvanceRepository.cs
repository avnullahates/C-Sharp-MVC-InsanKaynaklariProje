using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;

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


        
    }
}
