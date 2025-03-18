using TimeService.Configuration;
using TimeService.Services;

namespace TimeService.Hosting;

public static class ServiceConfiguration
{
    public static IServiceCollection AddMvcServices(this IServiceCollection services)
    {
        services.AddControllers();
        
       return services
            .ConfigureJsonSettings()
            .ConfigureBinderProviders();
       
    }
    
    public static IServiceCollection AddOpenApiServices(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        
        services.AddSwaggerGen();
        
        services.ConfigureOptions<SwaggerDocOptions>();
        
        return services;
    }
    
    public static IServiceCollection AddClockServices(this IServiceCollection services)
    {
        // Add Clock service to the container.
        services.AddScoped<IClockService, ClockService>();

        return services;
    }

    private static IServiceCollection ConfigureJsonSettings(this IServiceCollection services)
    {
        services.ConfigureOptions<JsonConfigurationOptions>();
        
        return services;
    }

    private static IServiceCollection ConfigureBinderProviders(this IServiceCollection services)
    {
        services.ConfigureOptions<BinderProviderOptions>();
        
        return services;
    }
    

    
}