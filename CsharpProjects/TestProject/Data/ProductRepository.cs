using TestProject.Models;

namespace TestProject.Data;

public class ProductRepository
{
    private readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Laptop Pro", Price = 1299.99m, Category = "Tecnología" },
        new Product { Id = 2, Name = "Mouse Gamer", Price = 79.50m, Category = "Accesorios" },
        new Product { Id = 3, Name = "Teclado Mecánico", Price = 149.00m, Category = "Accesorios" }
    };

    public IReadOnlyList<Product> GetAll()
    {
        return _products;
    }

    public void Add(Product product)
    {
        product.Id = _products.Count == 0 ? 1 : _products.Max(p => p.Id) + 1;
        _products.Add(product);
    }
}
