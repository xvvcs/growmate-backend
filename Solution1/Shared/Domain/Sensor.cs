namespace Shared.Domain;

public class Sensor
{
    public string Type { get; set; }
    public string MetricUnit  { get; set; }
    public int ThresholdValue { get; set; }
    
    public int GreenhouseId { get; set; }
}