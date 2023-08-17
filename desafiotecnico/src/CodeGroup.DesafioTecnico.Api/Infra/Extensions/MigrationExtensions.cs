using Microsoft.EntityFrameworkCore;

namespace CodeGroup.DesafioTecnico.Api.Infra.Extensions;

public static class MigrationExtensions
{
    public static IServiceProvider MigrateDatabase<TContext>(this IServiceProvider service) where TContext : DbContext
    {
        using (var scope = service.GetService<IServiceScopeFactory>().CreateScope())
        {
            using (var appContext = scope.ServiceProvider.GetRequiredService<TContext>())
            {
                try
                {
                    appContext.Database.Migrate();
                }
                catch (Exception ex)
                {
                    if (!ex.Message.Contains("already exists"))
                        throw;
                }
            }
        }
        return service;
    }
}
