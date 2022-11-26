using CoreLayer.Entities;
using CoreLayer.Enums;
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
        private readonly Context _dbContext;

        public EFPermitRepository(Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Permit> GetListAllPermit(string id)
        {
            return _dbContext.Permits.Include(a => a.Personnel).Where(a => a.PersonnelID == id).ToList();
        }

        public bool Approved(int id)
        {
            Permit approved = GetById(id);
            approved.Approval = Approval.Onaylandı;
            return Update(approved);
        }
        public bool Rejected(int id)
        {
            Permit approved = GetById(id);
            approved.Approval = Approval.Reddedildi;
            return Update(approved);
        }

        public List<Permit> GetAllPermitWithPersonnel()
        {
            return _dbContext.Permits.Include(a => a.Personnel).ToList();
        }
    }
}
