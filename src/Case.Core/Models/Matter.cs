namespace Case.Core.Models;

public class Matter
{
    public string ClientReference { get; set; }
    public int MatterNumber { get; set; }
    public string Description { get; set; }
    public Guid WorkTypeId { get; set; }
    public string Status { get; set; }
    public string Currency { get; set; }
    
    public Client Client { get; set; }
    public WorkType WorkType { get; set; }
}