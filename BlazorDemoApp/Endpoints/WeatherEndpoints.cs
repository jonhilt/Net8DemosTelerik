using BlazorDemoApp.Shared.Weather;

namespace BlazorDemoApp.Endpoints;

public static class WeatherEndpoints
{
    public static void MapWeatherEndpoints(this WebApplication app)
    {
        app.MapGet("api/weather", Handler);
    }

    private static async Task<IResult> Handler(HttpContext context, IWeatherService weatherService)
    {
        return Results.Ok(await weatherService.FetchAsync());
    }
}