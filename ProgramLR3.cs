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

class Program
{
    static void Main(string[] args)
    {
        var productRepository = new ProductRepository();

        // Додавання продуктів
        productRepository.Add(new Product(1, "Продукт 1", 100));
        productRepository.Add(new Product(2, "Продукт 2", 200));
        productRepository.Add(new Product(3, "Продукт 3", 300));

        Console.WriteLine("Всі продукти:");
        foreach (var product in productRepository.GetAll())
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }

        // Сортування за назвою
        Console.WriteLine("\nПродукти, відсортовані за назвою:");
        foreach (var product in productRepository.GetSortedByName())
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }

        // Сортування за ціною
        Console.WriteLine("\nПродукти, відсортовані за ціною:");
        foreach (var product in productRepository.GetSortedByPrice())
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }

        // Фільтрація продуктів за ціною
        Console.WriteLine("\nФільтровані продукти (ціна > 150):");
        foreach (var product in productRepository.GetProductsAbovePrice(150))
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }

        // Видалення продукту
        Product productToRemove = productRepository.GetById(2);
        productRepository.Remove(productToRemove);

        // Виведення після видалення
        Console.WriteLine("\nПродукти після видалення:");
        foreach (var product in productRepository.GetAll())
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }
    }
}
