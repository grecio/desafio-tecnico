using CodeGroup.DesafioTecnico.Api.Infra.Database.DbContexts;
using CodeGroup.DesafioTecnico.Api.Infra.Database.SqlServer;

namespace CodeGroup.DesafioTecnico.Api.IoC.Extensions;

public static class SetupApi
{
    public static IServiceCollection AddDependencies(this IServiceCollection services, string apiName)
    {
        services.AddDatabase<CodeGroupDbContext>("Data Source=DESKTOP-UCMKJG7\\SQLEXPRESS; Initial Catalog=CodeGroup; Integrated Security=True;Connect Timeout=600;TrustServerCertificate=True;");

        return services;
    }

    public static WebApplication UseMigrations(this WebApplication app)
    {
        app.Services.MigrateDatabase<CodeGroupDbContext>();

        return app;
    }
}
