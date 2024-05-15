using BusinessObjects.Models;
using Repositories.Abstractions;
using Repositories.Repositories;
using Services.Abstractions;

namespace Services.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _iCategoryRepository;

    public CategoryService()
    {
        _iCategoryRepository = new CategoryRepository();
    }

    public List<Category> GetAllCategories()
    {
        return _iCategoryRepository.GetAllCategories();
    }
}