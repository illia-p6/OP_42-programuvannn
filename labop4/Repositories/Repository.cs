using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labop4.Models;

namespace labop4.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected List<T> _entities = new List<T>();

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault(e => e.ID == id);
        }

        public List<T> GetAll()
        {
            return new List<T>(_entities);
        }
    }
}
