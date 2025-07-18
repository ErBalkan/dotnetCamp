using Core;
using Entities;

namespace DataAccess;

public class InMemoryProductRepository : IRepository<Product>
{
    private readonly List<Product> _products;

    public InMemoryProductRepository()
    {
        _products = new List<Product>
        {
            new Product{Id=1,Name="Laptop",UnitPrice=12000,Stock=10},
            new Product{Id=2,Name="Klavye",UnitPrice=500,Stock=25},
            new Product{Id=3,Name="Mouse",UnitPrice=300,Stock=30},
        };
    }
    public void Add(Product entity)
    {
        _products.Add(entity);
    }

    public void Delete(Product entity)
    {
        Product? product = _products.FirstOrDefault(p => p.Id == entity.Id);
        if (product != null)
            _products.Remove(product);
        Console.WriteLine("Böyle bir product mevcut değil.");
    }

    public List<Product> GetAll() => _products;

    public Product GetById(int id)
    {
        Product? product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null) return new Product();
        return product;

    }

    public void Update(Product entity)
    {
        Product? product = _products.FirstOrDefault(p => p.Id == entity.Id);
        if (product != null)
        {
            product.Name = entity.Name;
            product.UnitPrice = entity.UnitPrice;
            product.Stock = entity.Stock;
        }
    }
}