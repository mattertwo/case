namespace Case.Infrastructure.Persistence.Entities;

public class Matter
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string WorkTypeId { get; set; }
    public string Status { get; set; }
    public string Currency { get; set; }
}