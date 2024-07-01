namespace TODO.Domain.Entities
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool Done { get; set; }
        public int TodoListId { get; set; }

        public TodoList TodoList { get; set; } = new TodoList();
    }
}
