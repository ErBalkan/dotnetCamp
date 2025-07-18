using Core;
using Entities;

namespace DataAccess;

public class EfProductRepository : IRepository<Product>
{
    private readonly AppDbContext _context;
    public EfProductRepository(AppDbContext context)
    {
        _context = context;
    }
    public void Add(Product entity)
    {
        _context.Products.Add(entity);
    }

    public void Delete(Product entity)
    {
        _context.Products.Remove(entity);
        _context.SaveChanges();
    }

    public List<Product> GetAll() => _context.Products.ToList();

    public Product? GetById(int id) => _context.Products.Find(id);
    public void Update(Product entity)
    {
        _context.Products.Update(entity);
        _context.SaveChanges();
    }
}