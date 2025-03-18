using NodaTime.Text;

namespace TimeService.Common.Extensions;

public static class NodaTimeExtensions
{
    public static bool TryParse<T>(this IPattern<T> pattern, string value, out ParseResult<T> result)
    {
        result = pattern.Parse(value);
        return result.Success;
    }
}