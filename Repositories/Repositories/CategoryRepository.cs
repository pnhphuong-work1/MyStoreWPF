using DataAccessLayer;
using DataAccessLayer.DAOs;
using BusinessObjects.Models;
using Repositories.Abstractions;

namespace Repositories.Repositories;

public class CategoryRepository : ICategoryRepository
{
    public List<Category> GetAllCategories() => CategoryDAO.GetAllCategories();
}