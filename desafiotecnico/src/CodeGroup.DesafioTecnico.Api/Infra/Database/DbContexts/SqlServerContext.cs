using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CodeGroup.DesafioTecnico.Api.Infra.Database.DbContexts;

public sealed class SqlServerContext
{
    private readonly IServiceCollection _services;

    public SqlServerContext(IServiceCollection services)
    {
        _services = services;
    }

    public void AddSqlServer<TContext>(string? connectionString, ServiceLifetime service, Type migrationAssemblyType) where TContext : DbContext
    {
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new ArgumentException(null, nameof(connectionString));
        }

        if ((object)migrationAssemblyType == null)
        {
            throw new ArgumentException(null, nameof(migrationAssemblyType));
        }

        Assembly assembly = AppDomain.CurrentDomain.Load(migrationAssemblyType.Assembly.GetName());

        _services.AddEntityFrameworkSqlServer().AddDbContext<TContext>((DbContextOptionsBuilder opt) =>
        {

            opt.UseSqlServer(connectionString, (SqlServerDbContextOptionsBuilder builderOptions) =>
            {

                builderOptions.MigrationsAssembly(assembly.ToString());

            });

            opt.EnableSensitiveDataLogging();
            opt.EnableDetailedErrors();

        }, service, service);

    }
}
