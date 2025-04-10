namespace Shared.Domain;

public class Plant
{
    public string Name { get; set; }
    public string Species { get; set; }
    public List<Picture> Images { get; set; }
    
    public int GreenhouseId { get; set; }
}