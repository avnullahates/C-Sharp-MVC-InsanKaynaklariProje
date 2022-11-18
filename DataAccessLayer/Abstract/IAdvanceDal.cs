
using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAdvanceDal : IGENERICDAL<Advance>
    {
        List<Advance> GetListAllAdvance(string id);
    }
}
