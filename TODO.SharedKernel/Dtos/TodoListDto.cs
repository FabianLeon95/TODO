namespace TODO.SharedKernel.Dtos
{
    public class TodoListDto
    {
        public required int Id { get; init; }
        public required string Title { get; init; }
        public IEnumerable<TodoItemDto> TodoItems { get; init; } = Enumerable.Empty<TodoItemDto>();
    };
}
