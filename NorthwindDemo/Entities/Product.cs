using Core;

namespace Entities;

public class Product : IEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal UnitPrice { get; set; }
    public int Stock { get; set; }

    // public Product(int id, string name, decimal unitPrice, int stock)
    // {
    //     this.Id = id;
    //     this.Name = name;
    //     this.UnitPrice = unitPrice;
    //     this.Stock = stock;
    // }    
}

