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

        public List<Advance> GetListAllAdvance(string id)
        {
            return _advanceDal.GetListAllAdvance(id);
        }
    }
}
