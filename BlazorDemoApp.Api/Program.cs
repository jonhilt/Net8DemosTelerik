using BlazorDemoApp.Api.Features.Orders;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

Task Transformer(OpenApiSchema schema, OpenApiSchemaTransformerContext context, CancellationToken arg3)
{
    var type = context.JsonTypeInfo.Type;

    if (!type.IsNested)
        return Task.CompletedTask;

    const string schemaId = "x-schema-id";
    schema.Annotations[schemaId] = $"{type.DeclaringType?.Name}{type.Name}";

    schema.Title = $"{type.DeclaringType?.Name}{type.Name}";
    schema.Description = $"Request/Response for {type.DeclaringType?.Name}{type.Name}";
    
    return Task.CompletedTask;
}

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi(options => { options.AddSchemaTransformer(Transformer); });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => { options.SwaggerEndpoint("/openapi/v1.json", "v1"); });
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
            .ToArray();
        return forecast;
    })
    .WithName("GetWeatherForecast");

app.MapOrderEndpoints();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}