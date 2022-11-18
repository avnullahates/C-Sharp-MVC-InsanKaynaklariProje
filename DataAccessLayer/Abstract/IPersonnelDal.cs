
using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IPersonnelDal : IGENERICDAL<Personnel>
    {
        List<Personnel> GetAllPersonelsWithDepartmentFilter(Expression<Func<Personnel, bool>> exp);

        List<Personnel> GetAllPersonelsWithDepartment();
    }
}
