using BusinessObjects.Models;

namespace Repositories.Abstractions;

public interface ICategoryRepository
{
    List<Category> GetAllCategories();
}