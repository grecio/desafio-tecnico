using CodeGroup.DesafioTecnico.Api.Infra.Configurations;
using CodeGroup.DesafioTecnico.Api.IoC;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace CodeGroup.DesafioTecnico.Api;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "CodeGroup.DesafioTecnico.Api", Version = "v1" });
        });

        services.AddAutoMapperConfig();
        services.AddHttpContextAccessor();

        services.AddApiVersioning(v =>
        {
            v.AssumeDefaultVersionWhenUnspecified = true;
            v.DefaultApiVersion = new ApiVersion(DateTime.Now);
        });

        InjectorBootStrapper.RegisterServices(services);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CodeGroup.DesafioTecnico.Api v1"));


        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

    }

}
