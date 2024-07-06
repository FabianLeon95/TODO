namespace TODO.SharedKernel.Dtos
{
    public class TodoItemDto
    {
        public required int Id { get; init; }
        public required string Description { get; init; }
        public required bool IsDone { get; init; }
    }
}
