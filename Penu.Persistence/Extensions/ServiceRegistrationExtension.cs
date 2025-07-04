using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Penu.Persistence.Context;

namespace Penu.Persistence.Extensions
{
    public static class ServiceRegistrationExtension
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PenuDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("LOCAL"));
            });

            return services;
        }
    }
}
