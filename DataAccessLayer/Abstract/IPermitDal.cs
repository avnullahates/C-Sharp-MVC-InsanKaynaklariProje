using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IPermitDal : IGENERICDAL<Permit>
    {
        List<Permit> GetListAllPermit(string id);
    }
}
