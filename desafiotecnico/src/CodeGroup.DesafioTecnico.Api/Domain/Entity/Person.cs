namespace CodeGroup.DesafioTecnico.Api.Domain.Entity;

public class Person : Abstractions.Entity
{
    public string? Name { get; set; }
    public DateTime BirthDate { get; set; }
    public string? Cpf { get; set; }
    public bool IsEmployee { get; set; }
}
