using System.Reflection;
using Microsoft.OpenApi.Models;
using NodaTime.Serialization.SystemTextJson;
using TimeService.Configuration;
using TimeService.Hosting;
using TimeService.Models.Binding.Providers;
using TimeService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvcServices()
    .AddOpenApiServices()
    .AddClockServices();

builder.Services.Configure<ClockServiceOptions>(ClockServiceOptions.DisplayValues,
    builder.Configuration.GetSection(ClockServiceOptions.DisplayValues));

var app = builder.Build();

if (app.Environment.IsDevelopment()) { }

app.MapControllers();

app.Run();