using System;
using System.Collections.Generic;
using System.Linq;

public class BaseEntity
{
    public int Id { get; set; }

    protected BaseEntity(int id)
    {
        Id = id;
    }
}

public interface IRepository<T> where T : BaseEntity
{
    void Add(T entity);
    void Remove(T entity);
    T GetById(int id);
    List<T> GetAll();
}
