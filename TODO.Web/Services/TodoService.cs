
namespace TODO.Web.Services
{
    public class TodoService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _httpClient;

        public TodoService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient("TodoAPI");
        }

        public async Task GetTodoItemsAsync()
        {
            var response = await _httpClient.GetAsync("/todoitems");

        }
    }

    public class TodoItem { }
}
