using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TODO.Domain.Services;
using TODO.Infrastructure.Database;
using TODO.Infrastructure.Email;

namespace TODO.Infrastructure
{
    public static class Extensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration) // Extension Method
        {
            services.AddDbContext<TodoDbContext>(config =>
            {
                config.UseSqlServer(configuration.GetConnectionString("TODOConnection"));
            });
            services.AddTransient<IEmailService, SendGridEmailService>();
        }
    }
}
