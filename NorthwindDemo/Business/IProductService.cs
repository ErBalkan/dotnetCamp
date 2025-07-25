using Entities;

namespace Business;

public interface IProductService
{
    List<Product> GetAll();
    Product GetById(int id);
    void Add(Product product);
    void Update(Product product);
    void Delete(Product product);
}