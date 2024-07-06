using Microsoft.EntityFrameworkCore;
using TODO.Domain.Repositories;

namespace TODO.Infrastructure.Database.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly TodoDbContext DbContext;
        protected readonly DbSet<TEntity> EntitySet;

        public Repository(TodoDbContext dbContext)
        {
            DbContext = dbContext;
            EntitySet = dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return EntitySet.AsNoTracking();
        }

        public virtual async Task<TEntity?> GetByIdAsync(int id)
        {
            return await EntitySet.FindAsync(id);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await EntitySet.AddAsync(entity);
            await DbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            EntitySet.Update(entity);
            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var entity = await DbContext.Set<TEntity>().FindAsync(id);
            if (entity is not null)
            {
                EntitySet.Remove(entity);
                await DbContext.SaveChangesAsync();
            }

            throw new KeyNotFoundException($"Entity of type {typeof(TEntity).Name} with ID {id} was not found.");
        }
    }
}
