using Business.Abstracts;
using DataAccess.Abstracts;
using Entities;

namespace Business.Concretes;

public class ProductManager:IProductService
{
    //private readonly InMemoryProductRepository _repository;
    //private readonly EfProductRepository _efProductRepository;

    private readonly IProductRepository _repository;

    //loouse coupling

    public ProductManager(IProductRepository repository)
    {
        _repository = repository;
    }

    public void Add(Product product)
    {
        if (product.Price < 0)
        {
            throw new Exception("Price cannot be less than 0");
        }
        //_repository.Add(product);
        //_efProductRepository.Add(product);
        _repository.Add(product);
    }

    public List<Product> GetAll()
    {
        //return _efProductRepository.GetAll();
        return _repository.GetAll();
    }

}
