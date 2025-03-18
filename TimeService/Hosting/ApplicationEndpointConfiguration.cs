using TimeService.Configuration;

namespace TimeService.Hosting;

public static class ApplicationEndPointConfiguration
{
    public static IApplicationBuilder MapEndPoints(IApplicationBuilder app)
    {
        app.UseHttpsRedirection();

        app.UseAuthorization();
        
        return app;
    }
} 