using CodeGroup.DesafioTecnico.Api.Infra.Extensions;

namespace CodeGroup.DesafioTecnico.Api
{
    public static class Program
    {

        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args"></param>
        /// <author>
        /// Arquitetura - Engenharia - Banco ABCBrasil - 2021
        /// </author>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// CreateHostBuilder.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        /// <author>
        /// Arquitetura - Engenharia - Banco ABCBrasil - 2021
        /// </author>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfigurationManager()
                .ConfigureWebHostDefaults(_ =>
                {
                    _.UseStartup<Startup>();
                });

    }
}