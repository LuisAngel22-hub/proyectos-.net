using TestProject.Data;
using TestProject.Models;
using TestProject.Views;

namespace TestProject.Controllers;

public class ProductController
{
    private readonly ProductRepository _repository = new();
    private readonly ProductView _view = new();

    public void Run()
    {
        while (true)
        {
            _view.ShowHeader();
            _view.ShowProducts(_repository.GetAll());

            var option = _view.ShowMenu();

            switch (option)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    _view.ShowMessage("Gracias por probar la app MVC en .NET.");
                    return;
                default:
                    _view.ShowError("Opción no válida. Intenta de nuevo.");
                    break;
            }
        }
    }

    private void AddProduct()
    {
        var product = _view.AskForNewProduct();

        if (product is null)
        {
            _view.ShowError("Los datos ingresados no son válidos.");
            return;
        }

        _repository.Add(product);
        _view.ShowMessage("Producto agregado correctamente.");
    }
}
