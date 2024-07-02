using Microsoft.EntityFrameworkCore;
using TODO.Domain.Repositories;

namespace TODO.Infrastructure.Database.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly TodoDbContext DbContext;
        private readonly DbSet<TEntity> _entitySet;

        public Repository(TodoDbContext dbContext)
        {
            DbContext = dbContext;
            _entitySet = dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _entitySet.AsNoTracking();
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            return await _entitySet.FindAsync(id);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _entitySet.AddAsync(entity);
            await DbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _entitySet.Update(entity);
            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var entity = await DbContext.Set<TEntity>().FindAsync(id);
            if (entity is not null)
            {
                _entitySet.Remove(entity);
                await DbContext.SaveChangesAsync();
            }

            throw new KeyNotFoundException($"Entity of type {typeof(TEntity).Name} with ID {id} was not found.");
        }
    }
}
