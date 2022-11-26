using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IPermitService
    {
        List<Permit> GetListAllPermit(string id);
        List<Permit> GetListAllPermit();
        bool Approved(int id);
        bool Rejected(int id);
        List<Permit> GetAllPermitWithPersonnel();
    }
}
