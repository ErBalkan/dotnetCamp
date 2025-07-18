using Core;
using Entities;

namespace Business;

public class ProductManager : IProductService
{
    private readonly IRepository<Product> _productRepository;

    public ProductManager(IRepository<Product> productRepository)
    {
        _productRepository = productRepository;
    }
    public void Add(Product product)
    {
        _productRepository.Add(product);
    }

    public void Delete(Product product)
    {
        _productRepository.Delete(product);
    }

    public List<Product> GetAll()
    {
        return _productRepository.GetAll();
    }

    public Product GetById(int id)
    {
        return _productRepository.GetById(id);
    }

    public void Update(Product product)
    {
        _productRepository.Update(product);
    }
}