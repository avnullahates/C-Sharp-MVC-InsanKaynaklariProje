using CoreLayer.Entities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> :IGENERICDAL<T> where T :class, IBaseEntity
    {
        private readonly Context _dbContext;

        public GenericRepository(Context dbContext) 
        {
            _dbContext = dbContext;
        }

        public bool Activate(int id)
        {
            T activated = GetById(id);
            activated.Status = true;
            return Update(activated);
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _dbContext.Set<T>().Any(exp);
        }

        public List<T> GetActive()
        {
            return _dbContext.Set<T>().Where(x => x.Status == true).ToList();
        }

        public T GetByDefault(Expression<Func<T, bool>> exp)
        {
            return _dbContext.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            return _dbContext.Set<T>().Where(exp).ToList();
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

        public bool Insert(List<T> t)
        {
            try
            {
               
                using (TransactionScope ts = new TransactionScope())
                {
                    _dbContext.Set<T>().AddRange(t);
                    return Save() > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(T t)
        {
           _dbContext.Remove(t);
            return Save() > 0;
        }

        public bool Remove(int id)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    T item = GetById(id);
                    item.Status = false;
                    ts.Complete();
                    return Update(item);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveAll(Expression<Func<T, bool>> exp)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    var koleksiyon = GetListAll(exp);
                    int count = 0;

                    foreach (var item in koleksiyon)
                    {
                        item.Status = false;
                        bool opResult = Update(item);
                        if (opResult) count++; // Her bir satır için işlem true dönüyorsa, yani update ediliyorsa sayacı 1 artır.
                    }
                    if (koleksiyon.Count == count)  //koleksiyondaki item sayısı benim foreache saydırdığım kadarına eşit olduğunda duracak ve tamamlayacak.
                    {
                        ts.Complete();
                    }
                    else
                    {
                        return false;
                    }
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public bool Update(T t)
        {
            try
            {
                _dbContext.Set<T>().Update(t);
                return Save() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
