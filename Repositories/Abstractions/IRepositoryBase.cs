using System.Linq.Expressions;

namespace Repositories.Abstractions;

public interface IRepositoryBase <TEntity, in TKey>
{
    public Task<IEnumerable<TEntity>> FindAll(CancellationToken cancellationToken = default);
    public Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
    public Task<TEntity?> FindById(TKey id, CancellationToken cancellationToken = default);
    public Task<TEntity> Add(TEntity entity, CancellationToken cancellationToken = default);
    public Task<TEntity> Update(TEntity entity, CancellationToken cancellationToken = default);
    public Task<bool> Remove(TEntity entity, CancellationToken cancellationToken = default);
}