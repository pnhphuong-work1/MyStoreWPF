using System.Linq.Expressions;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstractions;

namespace Repositories.Repositories;

public class RepositoryBase<TEntity, TKey> : IRepositoryBase<TEntity, TKey>
    where TEntity : class
    where TKey : notnull
{
    private readonly MyStoreContext _myStoreContext;

    protected RepositoryBase(MyStoreContext myStoreContext)
    {
        _myStoreContext = myStoreContext;
    }

    public async Task<IEnumerable<TEntity>> FindAll(CancellationToken cancellationToken = default)
    {
        return await _myStoreContext.Set<TEntity>()
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
    {
        return await _myStoreContext.Set<TEntity>()
            .Where(predicate)
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task<TEntity?> FindById(TKey id, CancellationToken cancellationToken = default)
    {
        return await _myStoreContext.Set<TEntity>().FindAsync(id, cancellationToken);
    }

    public async Task<TEntity> Add(TEntity entity, CancellationToken cancellationToken = default)
    {
        _myStoreContext.Set<TEntity>().Add(entity);
        await _myStoreContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<TEntity> Update(TEntity entity, CancellationToken cancellationToken = default)
    {
        _myStoreContext.Set<TEntity>().Update(entity);
        await _myStoreContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<bool> Remove(TEntity entity, CancellationToken cancellationToken = default)
    {
        _myStoreContext.Set<TEntity>().Remove(entity);
        var isSuccess = await _myStoreContext.SaveChangesAsync(cancellationToken);
        return isSuccess > 0;
    }
}