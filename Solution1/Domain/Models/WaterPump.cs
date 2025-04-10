﻿namespace Shared.Domain;

public class WaterPump
{
    public DateTime LastWateredTime { get; set; }
    public int LastWaterAmount { get; set; }
    public int WaterLevel { get; set; }
    public bool AutoWateringEnabled  { get; set; }
    public int WaterTankCapacity { get; set; }
    public int ThresholdValue { get; set; }
}