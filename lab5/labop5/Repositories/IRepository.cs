using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using labop4.Models;

namespace labop4.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Remove(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
}
