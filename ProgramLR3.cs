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

public class Product : BaseEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string name, decimal price) : base(id)
    {
        Name = name;
        Price = price;
    }
}

public class ProductRepository : Repository<Product>
{
    public IEnumerable<Product> GetSortedByName()
    {
        return GetAll().OrderBy(p => p.Name);
    }

    public IEnumerable<Product> GetSortedByPrice()
    {
        return GetAll().OrderBy(p => p.Price);
    }

    // Метод для фільтрації продуктів за ціною
    public IEnumerable<Product> GetProductsAbovePrice(decimal price)
    {
        return GetAll().Where(p => p.Price > price);
    }
}
