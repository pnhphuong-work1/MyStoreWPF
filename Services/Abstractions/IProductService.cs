using BusinessObjects.Models;

namespace Services.Abstractions;

public interface IProductService
{
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(Product product);
    List<Product> GetAllProducts();
    Product? GetProductById(int productId);
}