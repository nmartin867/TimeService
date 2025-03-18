using System.Text.Json;
using Microsoft.Extensions.Options;
using NodaTime.Serialization.SystemTextJson;

namespace TimeService.Configuration;

public class JsonConfigurationOptions : IConfigureOptions<JsonSerializerOptions>
{
    public void Configure(JsonSerializerOptions options)
    {
        options.Converters.Add(NodaConverters.InstantConverter);
        options.Converters.Add(NodaConverters.LocalTimeConverter);
        options.Converters.Add(NodaConverters.LocalDateTimeConverter);
        options.Converters.Add(NodaConverters.OffsetDateTimeConverter);
        options.Converters.Add(NodaConverters.OffsetTimeConverter);
    }
}
