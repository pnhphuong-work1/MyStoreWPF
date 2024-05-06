using DataAccessLayer;
using DataAccessLayer.Models;
using Repositories.Abstractions;

namespace Repositories.Repositories;

public class CategoryRepository : RepositoryBase<Category, int>, ICategoryRepository
{
    public CategoryRepository(MyStoreContext myStoreContext) : base(myStoreContext)
    {
    }
}