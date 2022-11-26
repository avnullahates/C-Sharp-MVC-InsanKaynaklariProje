using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdvanceService
    {
        List<Advance> GetListAllAdvance(string id);

        bool Approved(int id);
        bool Rejected(int id);
        decimal SumAdvance(string id);

        List<Advance> GetAllAdvanceWithPersonnel();
    }
}
