using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes.InMemory;

public class InMemoryProductRepository:IProductRepository
{
    private List<Product> _products;

    public InMemoryProductRepository()
    {
        _products = new List<Product>();
        _products.Add(new Product { Id = Guid.NewGuid(), Name = "Product 1", Price = 100 });
        _products.Add(new Product { Id = Guid.NewGuid(), Name = "Product 2", Price = 200 });
        _products.Add(new Product { Id = Guid.NewGuid(), Name = "Product 3", Price = 300 });
    }

    public void Add(Product product)
    {
        Console.WriteLine("Adding product to in-memory");
        _products.Add(product);
    }

    public List<Product> GetAll()
    {
        Console.WriteLine("Getting all products from in-memory");
        return _products;
    }
}
