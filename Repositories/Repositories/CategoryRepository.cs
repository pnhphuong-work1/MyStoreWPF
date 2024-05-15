using DataAccessLayer;
using DataAccessLayer.DAOs;
using DataAccessLayer.Models;
using Repositories.Abstractions;

namespace Repositories.Repositories;

public class CategoryRepository : ICategoryRepository
{
    public List<Category> GetAllCategories() => CategoryDAO.GetAllCategories();
}