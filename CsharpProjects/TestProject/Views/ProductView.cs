using TestProject.Models;

namespace TestProject.Views;

public class ProductView
{
    public void ShowHeader()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("====================================================");
        Console.WriteLine("|        DEMO MVC - INVENTARIO DE PRODUCTOS          |");
        Console.WriteLine("====================================================");
        Console.ResetColor();
    }

    public int ShowMenu()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("1. Agregar producto");
        Console.WriteLine("2. Salir");
        Console.Write("Seleccione una opción: ");
        Console.ResetColor();

        var input = Console.ReadLine();
        return int.TryParse(input, out var option) ? option : 0;
    }

    public void ShowProducts(IReadOnlyList<Product> products)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Listado de productos:");
        Console.ResetColor();

        if (products.Count == 0)
        {
            Console.WriteLine("No hay productos registrados.");
            return;
        }

        Console.WriteLine("ID  | Nombre                | Categoría       | Precio");
        Console.WriteLine("----+-----------------------+-----------------+---------");

        foreach (var product in products)
        {
            Console.WriteLine($"{product.Id,-3} | {product.Name,-21} | {product.Category,-15} | ${product.Price:F2}");
        }
    }

    public Product? AskForNewProduct()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Agregar nuevo producto");
        Console.ResetColor();

        Console.Write("Nombre: ");
        var name = Console.ReadLine();

        Console.Write("Categoría: ");
        var category = Console.ReadLine();

        Console.Write("Precio: ");
        var priceText = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category) || !decimal.TryParse(priceText, out var price))
        {
            return null;
        }

        return new Product
        {
            Name = name.Trim(),
            Category = category.Trim(),
            Price = price
        };
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ResetColor();
        Console.WriteLine("Presiona Enter para continuar...");
        Console.ReadLine();
    }

    public void ShowError(string message)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
        Console.WriteLine("Presiona Enter para continuar...");
        Console.ReadLine();
    }
}
