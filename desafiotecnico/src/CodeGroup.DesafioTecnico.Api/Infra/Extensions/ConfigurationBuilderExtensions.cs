namespace CodeGroup.DesafioTecnico.Api.Infra.Extensions;

public static class ConfigurationBuilderExtentions
{
    public static IHostBuilder ConfigureAppConfigurationManager(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureAppConfiguration(delegate (HostBuilderContext host, IConfigurationBuilder builder)
        {
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);
            builder.AddEnvironmentVariables();
        });
        return hostBuilder;
    }

}
