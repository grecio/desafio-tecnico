using Microsoft.EntityFrameworkCore;

namespace CodeGroup.DesafioTecnico.Api.Infra.Database.Abstractions;

public sealed class Migration
{
    private readonly IServiceProvider _serviceProvider;

    public Migration(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public void Migrate<TContext>() where TContext : DbContext
    {
        IServiceScopeFactory service = _serviceProvider.GetService<IServiceScopeFactory>();

        if (service == null)
        {
            throw new InvalidOperationException("Instancia de IServiceScopeFactory é nulo");
        }

        using IServiceScope serviceScope = service.CreateScope();
        using TContext val = serviceScope.ServiceProvider.GetRequiredService<TContext>();

        val.Database.Migrate();

    }
}
