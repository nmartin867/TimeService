using TimeService.Common.Configuration;

namespace TimeService.Configuration;

public class ClockServiceOptions
{
    public const string DisplayValues = nameof(DisplayValues);
    
    public string TimePattern { get; set; } = "HH:mm";
    public UnitTypes Units { get; set; } = UnitTypes.Degrees | UnitTypes.Radians;
}