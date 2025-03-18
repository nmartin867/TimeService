using Microsoft.Extensions.Options;
using TimeService.Common.Configuration;

namespace TimeService.Services;

public sealed class ClockService
{
    private readonly ServiceOptions _displayValues;

    public ClockService(IOptionsSnapshot<ServiceOptions> namedOptionsAccessor)
    {
        _displayValues = namedOptionsAccessor.Get(ServiceOptions.DisplayValues);
    }

}