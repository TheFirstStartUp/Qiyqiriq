using eShop.Domain.Exceptions;
using eShop.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace eShop.Infrastructure.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly eShopDbContext Context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(eShopDbContext context)
        {
            Context = context;
            _dbSet = Context.Set<TEntity>();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var entry = await _dbSet.AddAsync(entity);
            await Context.SaveChangesAsync();

            return entry.Entity;
        }

        public async Task<List<TEntity>> Filter(Expression<Func<TEntity, bool>> filter)
            => await _dbSet.Where(filter).ToListAsync();

        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> filter)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(filter);

            if (entity is null)
                throw new NotFoundException();

            return entity;
        }

        public IEnumerable<TEntity> GetAll() => _dbSet.ToList();

        public IQueryable<TEntity> Queryable() => _dbSet;

        public async Task<TEntity> RemoveAsync(TEntity entity)
        {
            var entry = _dbSet.Remove(entity);
            await Context.SaveChangesAsync();

            return entry.Entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var entry = _dbSet.Update(entity);
            await Context.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
