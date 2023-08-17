namespace CodeGroup.DesafioTecnico.Api.IoC;

public static class InjectorBootStrapper
{
    public static void RegisterServices(IServiceCollection services)
    {
        _ = services.Scan(s => s
             .FromApplicationDependencies(d => d.FullName!.StartsWith("CodeGroup"))
             .AddClasses().AsMatchingInterface((service, filter) =>
                 filter.Where(i => i.Name.Equals($"I{service.Name}", StringComparison.OrdinalIgnoreCase)
                 )).WithScopedLifetime()
          );
    }
}
