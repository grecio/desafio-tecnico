using CodeGroup.DesafioTecnico.Api.Domain.Entity;
using CodeGroup.DesafioTecnico.Api.Infra.Database.Mappings;
using Microsoft.EntityFrameworkCore;

namespace CodeGroup.DesafioTecnico.Api.Infra.Database.DbContexts;

public class CodeGroupDbContext : DbContext
{
    public CodeGroupDbContext(DbContextOptions<CodeGroupDbContext> options) : base(options)
    {
        
    }

    public DbSet<Person> Person { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfiguration(new PersonMap());

        base.OnModelCreating(modelBuilder);
    }
}
