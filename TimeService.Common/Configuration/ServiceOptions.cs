namespace TimeService.Common.Configuration;

public class ServiceOptions
{
    public const string DisplayValues = nameof(DisplayValues);
    
    public string TimePattern { get; set; } = "HH:mm";
    public UnitTypes Units { get; set; } = UnitTypes.Degrees | UnitTypes.Radians;
}