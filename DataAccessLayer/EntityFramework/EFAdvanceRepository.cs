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
    public class EFAdvanceRepository : GenericRepository<Advance>, IAdvanceDal
    {
        private readonly Context _dbContext;

        public EFAdvanceRepository(Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Advance> GetListAllAdvance(string id)
        {
            return _dbContext.Advances.Include(x => x.Personnel).Where(a => a.PersonnelID == id).ToList();
        }

        public bool Approved(int id)
        {
            Advance approved = GetById(id);
            approved.Approval = Approval.Onaylandı;
            return Update(approved);
        }
        public bool Rejected(int id)
        {
            Advance approved = GetById(id);
            approved.Approval = Approval.Reddedildi;
            return Update(approved);
        }

        public decimal SumAdvance(string id)
        {
            return _dbContext.Advances.Where(x => x.PersonnelID == id && x.Currency == Currency.TL && (x.Approval == Approval.Onaylandı || x.Approval == Approval.OnayBekliyor)).Sum(x => x.AdvanceAmount);
        }

        public List<Advance> GetAllAdvanceWithPersonnel()
        {
            return _dbContext.Advances.Include(a => a.Personnel).ToList();
        }
       
    }
}
