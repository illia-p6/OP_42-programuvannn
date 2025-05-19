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
        return _entities.FirstOrDefault(e => e.Id == id);
    }

    public List<T> GetAll()
    {
        return new List<T>(_entities);
    }
}