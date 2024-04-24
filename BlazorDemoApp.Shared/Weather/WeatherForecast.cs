namespace BlazorDemoApp.Shared.Weather;

public record WeatherForecastModel
{
    public IEnumerable<WeatherForecast> Forecasts { get; set; }
}

public record WeatherForecast
{
    public DateOnly Date { get; set; }
    public int TemperatureC { get; set; }
    public string Summary { get; set; }
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}