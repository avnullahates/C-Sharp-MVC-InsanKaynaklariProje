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
    public class GenericManager<T> : IGenericService<T> where T : BaseEntity
    {
        private readonly IGENERICDAL<T> _repository;
        public GenericManager(IGENERICDAL<T> repository )
        {
            _repository = repository;
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
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

    }
}
