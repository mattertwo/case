namespace Case.Core.Models;

public class WorkType
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    public Matter Matter { get; set; }
}