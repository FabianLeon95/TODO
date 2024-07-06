using TODO.SharedKernel.Dtos;

namespace TODO.Domain.Services
{
    public interface ITodoListsService
    {
        IEnumerable<TodoListDto> GetAll();
        Task<TodoListDto> GetByIdAsync(int id);
    }
}
