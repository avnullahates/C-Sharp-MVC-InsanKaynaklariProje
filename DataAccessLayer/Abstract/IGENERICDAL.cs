using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGENERICDAL<T> where T : IBaseEntity
    {
        T GetById(int id);
        List<T> GetListAll();
        List<T> GetListAll(Expression<Func<T, bool>> filter);

        bool Insert(T t);
        bool Insert(List<T> t);
        bool Update(T t);
        bool Remove(T t);
        bool Remove(int id);
        bool RemoveAll(Expression<Func<T, bool>> exp);
        T GetByDefault(Expression<Func<T, bool>> exp);
        List<T> GetActive();
        bool Activate(int id);
        bool Any(Expression<Func<T, bool>> exp);

        List<T> GetDefault(Expression<Func<T, bool>> exp);
        int Save();

    }
}
