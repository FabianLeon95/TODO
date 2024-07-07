namespace TODO.Domain.Repositories
{
    public interface IRepository<TEntity>
    {
        public IEnumerable<TEntity> GetAll(int id);
    }
}
