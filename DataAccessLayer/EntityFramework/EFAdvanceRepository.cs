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
        public EFAdvanceRepository(Context dbContext) : base(dbContext)
        {
        }
    }
}
