using Microsoft.EntityFrameworkCore;
using TODO.Domain.Entities;

namespace TODO.Infrastructure.Database
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
