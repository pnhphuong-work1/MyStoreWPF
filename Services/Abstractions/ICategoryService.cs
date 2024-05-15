using DataAccessLayer.Models;

namespace Services.Abstractions;

public interface ICategoryService
{
    List<Category> GetAllCategories();
}