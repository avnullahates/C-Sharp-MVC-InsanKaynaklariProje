using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICompanyDal : IGENERICDAL<Company>
    {
        Company GetAllPersonelsWithCompany(int id);
    }
}
