using Microsoft.EntityFrameworkCore;

namespace CodeGroup.DesafioTecnico.Api.Infra.Extensions
{
    public static class DbContextExtensions
    {
        public static IServiceCollection AddInMemoryContext<TContext>(this IServiceCollection services, string connectionString, ServiceLifetime service) where TContext : DbContext
        {

            if (string.IsNullOrEmpty(connectionString))
                throw new Exception("InMemory connection is empty.");

            services.AddInMemoryContext<TContext>(connectionString, service);

            return services;

        }
    }
}
