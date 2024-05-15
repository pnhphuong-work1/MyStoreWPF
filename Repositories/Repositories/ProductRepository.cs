using DataAccessLayer;
using DataAccessLayer.DAOs;
using DataAccessLayer.Models;
using Repositories.Abstractions;

namespace Repositories.Repositories;

public class ProductRepository : IProductRepository
{
    public List<Product> GetAllProducts() => ProductDAO.GetAllProducts();

    public Product? GetProductById(int id) => ProductDAO.GetProductById(id);

    public void UpdateProduct(Product product) => ProductDAO.UpdateProduct(product);

    public void AddProduct(Product product) => ProductDAO.AddProduct(product);

    public void DeleteProduct(Product product) => ProductDAO.DeleteProduct(product);
}