using DataAccessLayer.Models;

namespace DataAccessLayer.DAOs;

public class CategoryDAO
{
    public static List<Category> GetAllCategories()
    {
        var productList = new List<Category>();
        try
        {
            using var context = new MyStoreContext();
            productList = context.Categories.ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return productList;
    }
}