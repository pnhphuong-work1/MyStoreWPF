using DataAccessLayer;
using DataAccessLayer.Models;
using Repositories.Abstractions;

namespace Repositories.Repositories;

public class ProductRepository : RepositoryBase<Product, int>, IProductRepository
{
    public ProductRepository(MyStoreContext myStoreContext) : base(myStoreContext)
    {
    }
}