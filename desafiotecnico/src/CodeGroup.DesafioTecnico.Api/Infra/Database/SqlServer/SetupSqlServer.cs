using CodeGroup.DesafioTecnico.Api.Infra.Database.Abstractions;
using CodeGroup.DesafioTecnico.Api.Infra.Database.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace CodeGroup.DesafioTecnico.Api.Infra.Database.SqlServer;

public static class SetupSqlServer
{
    public static SqlServerContext AddDatabase<TContext>(this IServiceCollection services, string? connectionString) where TContext : DbContext
    {
        var sqlServerContext = new SqlServerContext(services);

        sqlServerContext.AddSqlServer<TContext>(connectionString, ServiceLifetime.Scoped, typeof(TContext));

        return sqlServerContext;
    }

    public static Migration MigrateDatabase<TContext>(this IServiceProvider serviceProvider) where TContext : DbContext
    {

        Migration migration = new(serviceProvider);
        migration.Migrate<TContext>();

        return migration;
    }
}
