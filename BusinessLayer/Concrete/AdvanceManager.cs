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
        
        public AdvanceManager(IAdvanceDal advanceDal)
        {
            _advanceDal = advanceDal;
            
        }

        public bool Approved(int id)
        {
            return _advanceDal.Approved(id);    
        }
        public bool Rejected(int id)
        {
            return _advanceDal.Rejected(id);
        }

        public List<Advance> GetListAllAdvance(string id)
        {
            return _advanceDal.GetListAllAdvance(id);
        }

        public decimal SumAdvance(string id)
        {
            return _advanceDal.SumAdvance(id);
        }

        public List<Advance> GetAllAdvanceWithPersonnel()
        {
            return _advanceDal.GetAllAdvanceWithPersonnel();
        }
    }
}
