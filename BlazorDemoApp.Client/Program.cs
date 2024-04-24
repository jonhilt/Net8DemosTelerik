using BlazorDemoApp.Client;
using BlazorDemoApp.Client.Weather;
using BlazorDemoApp.Shared.Data;
using BlazorDemoApp.Shared.Weather;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<IProductStore, ClientProductStore>();
builder.Services.AddScoped<IWeatherService, ClientWeatherService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();