namespace BlazorDemoApp.Shared.Weather;

public interface IWeatherService
{
    public Task<WeatherForecastModel?> FetchAsync();
}

