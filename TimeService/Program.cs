using FluentValidation;
using TimeService.Common.Validation;
using TimeService.Models.Binding.Providers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register the custom service
builder.Services.AddValidatorsFromAssemblyContaining<TimeOnlyValidator>();

builder.Services.AddControllers(options =>
{
    options.ModelBinderProviders.Insert(0, new TimeOnlyModelBinderProvider());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable middleware to serve generated Swagger as a JSON endpoint.
    app.UseSwagger(); 
    // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
    // // specifying the Swagger JSON endpoint.
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "TimeService v1");
        c.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
