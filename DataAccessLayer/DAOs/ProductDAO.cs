using BusinessObjects.DTOs;
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.DAOs;

public class ProductDAO
{
    public static List<Product> GetAllProducts()
    {
        var productList = new List<Product>();
        try
        {
            using var context = new MyStoreContext();
            productList = context.Products.Include(e => e.Category).ToList();

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return productList;
    }

    public static Product? GetProductById(int id)
    {
        using var context = new MyStoreContext();
        return context.Products.FirstOrDefault(p => p.ProductId == id);
    }

    public static void UpdateProduct(Product product)
    {
        try
        {
            using var context = new MyStoreContext();
            context.Products.Update(product);
            context.SaveChanges();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    
    public static void AddProduct(Product product)
    {
        try
        {
            using var context = new MyStoreContext();
            context.Products.Add(product);
            context.SaveChanges();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    
    public static void DeleteProduct(Product product)
    {
        try
        {
            using var context = new MyStoreContext();
            var existedProduct = context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            context.Products.Remove(existedProduct!);
            context.SaveChanges();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}