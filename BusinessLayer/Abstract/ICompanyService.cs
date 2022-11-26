using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICompanyService
    {
        List<Company> GetListAllCompanies();

        Company GetAllPersonelsWithCompany(int id);
    }
}
