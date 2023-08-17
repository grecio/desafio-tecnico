namespace CodeGroup.DesafioTecnico.Api.Domain.Entity;

public class Project : Abstractions.Entity
{
    public string? Name { get; set; }
    public DateTime InitialDate { get; set; }
    public DateTime FinalForecastDate { get; set; }
    public DateTime FinalDate { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
    public decimal Budget { get; set; }
    public string? Risk { get; set; }
    public long ManagerId { get; set; }

}
