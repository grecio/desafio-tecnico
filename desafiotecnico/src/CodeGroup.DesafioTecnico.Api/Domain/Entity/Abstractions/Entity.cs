using System.ComponentModel.DataAnnotations;

namespace CodeGroup.DesafioTecnico.Api.Domain.Entity.Abstractions;

public abstract class Entity
{
    [Key]
    public virtual long Id { get; protected set; }
}
