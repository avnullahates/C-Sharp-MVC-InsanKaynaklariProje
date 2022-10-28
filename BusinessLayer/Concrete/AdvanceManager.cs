using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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

    }
}
