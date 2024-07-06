using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TODO.Domain.Entities;
using TODO.Domain.Repositories;
using TODO.Domain.Services;
using TODO.Infrastructure.Database;
using TODO.Infrastructure.Database.Repositories;
using TODO.Infrastructure.Email;

namespace TODO.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration) // Extension Method
        {
            // Database
            services.AddDbContext<TodoDbContext>(config => config.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Repositories
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IRepository<TodoList>, TodoListsRepository>();

            // Services
            services.AddTransient<IEmailService, SendGridEmailService>();
        }
    }
}
