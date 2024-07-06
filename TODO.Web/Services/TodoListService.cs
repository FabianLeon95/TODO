
using Microsoft.Extensions.Options;
using TODO.SharedKernel.Dtos;
using TODO.Web.Settings;

namespace TODO.Web.Services
{
    public class TodoListService
    {
        private readonly HttpClient _httpClient;

        public TodoListService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<TodoListDto>> GetAllAsync()
        {
            var todoLists = await _httpClient.GetFromJsonAsync<IEnumerable<TodoListDto>>("todolists");

            return todoLists ?? throw new Exception("Failed to make the request.");
        }

        public async Task<TodoListDto> GetByIdAsync(int id)
        {
            var todoList = await _httpClient.GetFromJsonAsync<TodoListDto>($"todolists/{id}");

            return todoList ?? throw new Exception("Failed to make the request.");
        }
    }

}
