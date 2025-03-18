namespace TimeService.Models.Binding.Providers;

using System.Collections.Generic;

public static class TimeOnlyModelBinderFactory
{
    public static List<string> GetPatterns()
    {
        return new List<string> { "HH:mm", "HH:mm:ss", "HH:mm:ss.fff" };
    }
}