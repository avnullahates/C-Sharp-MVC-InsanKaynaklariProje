using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        T GetById(int id);
        List<T> GetListAll();
        List<T> GetListAll(Expression<Func<T, bool>> filter);

        bool Insert(T t);
    }
}
