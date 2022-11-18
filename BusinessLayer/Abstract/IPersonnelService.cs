using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PagedList;

namespace BusinessLayer.Abstract
{
    public interface IPersonnelService
    {
        List<Personnel> GetAllPersonelsWithDepartmentFilter(Expression<Func<Personnel, bool>> exp);

        List<Personnel> GetAllPersonelsWithDepartment();
    }
}
