using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace TimeService.Configuration;

public class SwaggerUiConfigurationOptions: IConfigureOptions<SwaggerUIOptions>
{
    public void Configure(SwaggerUIOptions options)
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "TimeService v1");
        
        options.RoutePrefix = string.Empty;
    }
}