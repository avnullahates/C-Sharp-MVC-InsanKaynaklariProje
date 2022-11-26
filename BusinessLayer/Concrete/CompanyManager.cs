using BusinessLayer.Abstract;
using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public Company GetAllPersonelsWithCompany(int id)
        {
            return _companyDal.GetAllPersonelsWithCompany(id);
        }

        public List<Company> GetListAllCompanies()
        {
            return _companyDal.GetListAll();
        }
    }
}
