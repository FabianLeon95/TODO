using TODO.Domain.Entities;
using TODO.SharedKernel.Dtos;

namespace TODO.Application.TodoItems
{
    public static class TodoItemsMapper
    {
        public static TodoItemDto MapToDto(this TodoItem entity)
        {
            return new TodoItemDto
            {
                Id = entity.Id,
                Description = entity.Description,
                IsDone = entity.IsDone,
            };
        }

        public static IEnumerable<TodoItemDto> MapToDto(this IEnumerable<TodoItem> entities)
        {
            return entities.Select(e => e.MapToDto());
        }
    }
}
