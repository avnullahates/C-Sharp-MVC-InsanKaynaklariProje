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
    public class EFManagerRepository : GenericRepository<Manager>, IManagerDal
    {
        public EFManagerRepository(Context dbContext) : base(dbContext)
        {

        }
    }
}
