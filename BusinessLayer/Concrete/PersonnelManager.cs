using BusinessLayer.Abstract;
using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PersonnelManager : IPersonnelService
    {
        IPersonnelDal _personnelDal;
        public PersonnelManager(IPersonnelDal personnelDal)
        {
            _personnelDal = personnelDal;
        }

       

        public List<Personnel> GetAllPersonelsWithDepartment()
        {
           return _personnelDal.GetAllPersonelsWithDepartment();
        }

        public List<Personnel> GetAllPersonelsWithDepartmentFilter(Expression<Func<Personnel, bool>> exp)
        {
            return _personnelDal.GetAllPersonelsWithDepartmentFilter(exp);
        }
    }
}
