using Entities;

namespace DataAccess.Abstracts;

public interface IProductRepository
{
    void Add(Product product);
    List<Product> GetAll();
}
