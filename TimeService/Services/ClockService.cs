using Microsoft.Extensions.Options;
using TimeService.Common.Configuration;
using TimeService.Configuration;

namespace TimeService.Services;

public interface IClockService
{
    
}
public sealed class ClockService : IClockService
{
    private readonly ClockServiceOptions _displayValues;

    public ClockService(IOptionsSnapshot<ClockServiceOptions> namedOptionsAccessor)
    {
        _displayValues = namedOptionsAccessor.Get(ClockServiceOptions.DisplayValues);
    }
}