using Microsoft.AspNetCore.Mvc.ModelBinding;
using TimeService.Common.Extensions;

namespace TimeService.Models.Binding;

public class TimeOnlyModelBinder : IModelBinder
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        var valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
        if (valueProviderResult == ValueProviderResult.None)
        {
            return Task.CompletedTask;
        }

        bindingContext.ModelState.SetModelValue(bindingContext.ModelName, valueProviderResult);

        var value = valueProviderResult.FirstValue;
        if (string.IsNullOrEmpty(value))
        {
            return Task.CompletedTask;
        }

        var pattern = NodaTime.Text.LocalTimePattern.ExtendedIso;
        if (pattern.TryParse(value, out var result))
        {
            bindingContext.Result = ModelBindingResult.Success(result.Value);
        }
        else
        {
            bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, "The value is not a valid LocalTime.");
        }
        
        return Task.CompletedTask;

        return Task.CompletedTask;
    }
}