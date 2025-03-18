using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TimeService.Models.Binding.Providers;

namespace TimeService.Configuration;

public class BinderProviderOptions : IConfigureOptions<MvcOptions>
{
    public void Configure(MvcOptions options)
    {
        options.ModelBinderProviders.Insert(0, new TimeOnlyModelBinderProvider());
    }
}