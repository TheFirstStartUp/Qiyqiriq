using System.Linq.Expressions;

namespace eShop.Infrastructure.Repositories.Base
{
    public interface IBaseRepository<TEntity>
    {
        Task<TEntity> AddAsync(TEntity entity);
        IEnumerable<TEntity> GetAll();
        IQueryable<TEntity> Queryable();
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> filter);
        Task<List<TEntity>> Filter(Expression<Func<TEntity, bool>> filter);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> RemoveAsync(TEntity entity);
    }
}
