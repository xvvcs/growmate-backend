namespace Shared.Domain;

public class Prediction
{
    public int OptimalTemperature { get; set; }
    public int OptimalLight { get; set; }
    public int OptimalHumidity { get; set; }
    public int OptimalWaterLevel { get; set; }
    public DateTime Date { get; set; }

    public int GreenhouseId { get; set; }
    public int SensorReadingId { get; set; }
}