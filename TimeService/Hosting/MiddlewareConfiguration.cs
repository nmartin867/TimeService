using Swashbuckle.AspNetCore.SwaggerUI;
using TimeService.Configuration;

namespace TimeService.Hosting;

public static class MiddlewareConfiguration
{
    public static IApplicationBuilder UseSwaggerDocs(this IApplicationBuilder app)
    {
    
        app.UseSwagger();

        app.UseSwaggerUI();

        app.UseMiddleware<SwaggerUIOptions>();
        
        return app;
    }

}