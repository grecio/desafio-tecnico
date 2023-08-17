using CodeGroup.DesafioTecnico.Api.Infra.Mapper;

namespace CodeGroup.DesafioTecnico.Api.Infra.Configurations;

public static class AutoMapperConfig
{
    public static void AddAutoMapperConfig(this IServiceCollection services)
    {
        if (services == null) throw new ArgumentNullException(nameof(services));

        services.AddAutoMapper(config =>
        {
            config.AddProfile(new CommandToEntityProfile());
        });
    }
}
