using System.Net.Http.Json;
using BlazorDemoApp.Shared.Weather;

namespace BlazorDemoApp.Client.Weather;

public class ClientWeatherService(HttpClient httpClient) : IWeatherService
{
    public async Task<WeatherForecastModel?> FetchAsync()
    {
        return await httpClient.GetFromJsonAsync<WeatherForecastModel>("api/weather");
    }
}