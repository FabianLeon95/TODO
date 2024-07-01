using TODO.Domain.Enum;

namespace TODO.Domain.Entities
{
    public class TodoList
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public Category Category { get; set; } = Category.Home;

        public ICollection<TodoItem> TodoItems { get; set; } = [];
    }
}
