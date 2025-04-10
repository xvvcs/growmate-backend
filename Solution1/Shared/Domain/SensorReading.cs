namespace Shared.Domain;

public class SensorReading
{
    public string Value { get; set; } // not sure what this should be
    public DateTime TimeStamp { get; set; }
    
    public int SensorReadingId { get; set; }
}