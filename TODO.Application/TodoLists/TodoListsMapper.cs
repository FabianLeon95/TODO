using TODO.Application.TodoItems;
using TODO.Domain.Entities;
using TODO.SharedKernel.Dtos;

namespace TODO.Application.TodoLists
{
    public static class TodoListsMapper
    {
        public static TodoListDto MapToDto(this TodoList entity)
        {
            return new TodoListDto
            {
                Id = entity.Id,
                Title = entity.Title,
                TodoItems =  entity.TodoItems.MapToDto()
            };
        }

        public static IEnumerable<TodoListDto> MapToDto(this IEnumerable<TodoList> entities)
        {
            return entities.Select(e => e.MapToDto());
        }
    }
}
