using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGENERICDAL<T> where T : BaseEntity
    {
        private readonly Context _dbContext;

        public GenericRepository(Context dbContext) 
        {
            _dbContext = dbContext;
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {

            return _dbContext.Set<T>().Where(filter).ToList();
        }

        public bool Insert(T t)
        {

            _dbContext.Add(t);
            return Save() > 0;
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }


    }
}
