using TimeService.Models.DTO;

namespace TimeService.Models.Binding.Providers;

using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

public class TimeOnlyModelBinderProvider : IModelBinderProvider
{
    public IModelBinder GetBinder(ModelBinderProviderContext context)
    {
        if (context.Metadata.ModelType == typeof(TimeOnlyRequest))
        {
            return new BinderTypeModelBinder(typeof(TimeOnlyModelBinder));
        }

        return null;
    }
}