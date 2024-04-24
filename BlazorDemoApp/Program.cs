using BlazorDemoApp.Components;
using BlazorDemoApp.Data;
using BlazorDemoApp.Endpoints;
using BlazorDemoApp.Shared.Data;
using BlazorDemoApp.Shared.Weather;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped(sp => new HttpClient 
{ 
    BaseAddress = new Uri("http://localhost:5023/") 
});

builder.Services.AddControllers();

builder.Services.AddScoped<IProductStore, ProductStore>();
builder.Services.AddScoped<IWeatherService, ServerWeatherService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode().AddAdditionalAssemblies(typeof(BlazorDemoApp.Client._Imports).Assembly);

app.MapWeatherEndpoints();

app.MapControllers();

app.Run();
