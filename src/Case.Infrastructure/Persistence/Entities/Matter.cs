namespace Case.Infrastructure.Persistence.Entities;

public class Matter
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Guid WorkTypeId { get; set; }
    public string Status { get; set; }
    public string Currency { get; set; }
}