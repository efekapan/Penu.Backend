using Microsoft.Extensions.DependencyInjection;

namespace Penu.Infrastructure.Extensions
{
    public static class ServiceRegistrationExtension
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            return services;
        }
    }
}
