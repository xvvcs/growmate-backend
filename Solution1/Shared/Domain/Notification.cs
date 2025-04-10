namespace Shared.Domain;

public class Notification
{
    public string Title { get; set; }
    public string Message { get; set; }
    public DateTime TimeStamp { get; set; }
    public bool IsRead { get; set; }
    
    public int WaterPumpId { get; set; }
    public int SensorReadingId { get; set; }
}