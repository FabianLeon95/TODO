using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TODO.Application.TodoLists;
using TODO.Domain.Services;

namespace TODO.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services, IConfiguration configuration) // Extension Method
        {
            services.AddTransient<ITodoListsService, TodoListsService>();
        }
    }
}
