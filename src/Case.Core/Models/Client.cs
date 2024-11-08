namespace Case.Core.Models;

public class Client
{
    public string Reference { get; set; }
    public string Name { get; set; }
    
    public ICollection<Matter> Matters { get; set; } = new List<Matter>();
}