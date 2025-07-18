using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public AppDbContext
    (DbContextOptions<AppDbContext> options) : base(options){}

}