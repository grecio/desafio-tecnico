using CodeGroup.DesafioTecnico.Api.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeGroup.DesafioTecnico.Api.Infra.Database.Mappings;

public class PersonMap : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("pessoa");
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id).HasColumnName("id").ValueGeneratedOnAdd();
        builder.Property(p => p.Name).HasColumnName("nome");
        builder.Property(p => p.BirthDate).HasColumnName("datanascimento");
        builder.Property(p => p.Cpf).HasColumnName("cpf");
        builder.Property(p => p.IsEmployee).HasColumnName("funcionario");

    }
}
