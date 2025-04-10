namespace Shared.Domain;

public class Picture
{
    public DateTime Date { get; set; }
    public string Url { get; set; }
    public string Note { get; set; }
    
    public int PlantId { get; set; }
}