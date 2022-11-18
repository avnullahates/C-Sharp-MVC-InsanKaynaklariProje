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
    public class GenericManager<T> : IGenericService<T> where T :class, IBaseEntity
    {
        private readonly IGENERICDAL<T> _repository;
        public GenericManager(IGENERICDAL<T> repository)
        {
            _repository = repository;
        }

        public bool Activate(int id)
        {
            if (id == 0 || GetById(id) == null)
            {
                return false;
            }
            else
            {
                return _repository.Activate(id);
            }
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _repository.Any(exp);
        }

        public List<T> GetActive()
        {
            return _repository.GetActive();
        }

        public T GetByDefault(Expression<Func<T, bool>> exp)
        {
            return _repository.GetByDefault(exp);
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            return _repository.GetDefault(exp);
        }


        public List<T> GetListAll()
        {
            return _repository.GetListAll();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            return _repository.GetListAll(filter);
        }

        public bool Insert(T t)
        {
            return _repository.Insert(t);
        }

        public bool Insert(List<T> t)
        {
            return _repository.Insert(t);
        }

        public bool Remove(T t)
        {
            if (t == null)
            {
                return false;

            }
            else
            {
                return _repository.Remove(t);
            }
        }

        public bool Remove(int id)
        {
            if (id <= 0)
            {
                return false;
            }
            else
            {
                return _repository.Remove(id);
            }
        }

        public bool RemoveAll(Expression<Func<T, bool>> exp)
        {
            return _repository.RemoveAll(exp);
        }

        public bool Update(T t)
        {
            if (t == null)
            {
                return false;
            }
            else
            {
                return _repository.Update(t);
            }
        }
    }
}
