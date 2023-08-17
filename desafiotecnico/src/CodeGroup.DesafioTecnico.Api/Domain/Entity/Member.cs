namespace CodeGroup.DesafioTecnico.Api.Domain.Entity;

public class Member : Abstractions.Entity
{
    public long ProjectId { get; set; }
    public long PersonId { get; set; }
}
