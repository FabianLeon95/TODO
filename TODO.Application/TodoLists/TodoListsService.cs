using TODO.Domain.Entities;
using TODO.Domain.Repositories;
using TODO.Domain.Services;
using TODO.SharedKernel.Dtos;

namespace TODO.Application.TodoLists
{
    public class TodoListsService : ITodoListsService
    {
        private readonly IRepository<TodoList> _repository;

        public TodoListsService(IRepository<TodoList> repository)
        {
            _repository = repository;
        }

        public IEnumerable<TodoListDto> GetAll()
        {
            var todoLists = _repository.GetAll().ToList();

            return todoLists.MapToDto();
        }

        public async Task<TodoListDto> GetByIdAsync(int id)
        {
            var todoList = await _repository.GetByIdAsync(id);

            if (todoList is not null)
            {
                return todoList.MapToDto();
            }

            throw new KeyNotFoundException($"Entity of type {typeof(TodoList).Name} with ID {id} was not found.");
        }
    }
}
