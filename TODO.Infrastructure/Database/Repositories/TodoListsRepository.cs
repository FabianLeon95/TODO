using Microsoft.EntityFrameworkCore;
using TODO.Domain.Entities;
using TODO.Domain.Repositories;

namespace TODO.Infrastructure.Database.Repositories
{
    public class TodoListsRepository : Repository<TodoList>, IRepository<TodoList>
    {
        public TodoListsRepository(TodoDbContext dbContext) : base(dbContext) { }

        public override Task<TodoList?> GetByIdAsync(int id)
        {
            return EntitySet
                .AsNoTracking()
                .Include(t => t.TodoItems)
                .SingleOrDefaultAsync(t => t.Id == id);
        }
    }
}
