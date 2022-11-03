using BusinessLayer.Abstract;
using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdvanceManager : IAdvanceService
    {
        IAdvanceDal _advanceDal;
        private readonly Context _context;

        public AdvanceManager(IAdvanceDal advanceDal, Context context)
        {
            _advanceDal = advanceDal;
            _context = context;
        }

        public List<Advance> GetListAllAdvance()
        {
            return _context.Advances.Include(x => x.PersonnelID).ToList();
        }
    }
}
