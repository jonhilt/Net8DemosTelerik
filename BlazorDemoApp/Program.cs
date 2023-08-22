using BlazorDemoApp;
using BlazorDemoApp.Data;
using BlazorDemoApp.Shared.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddWebAssemblyComponents()
    .AddServerComponents();

builder.Services.AddScoped(sp => new HttpClient 
{ 
    BaseAddress = new Uri("http://localhost:5023/") 
});

builder.Services.AddControllers();

builder.Services.AddScoped<IProductStore, ProductStore>();

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
    .AddServerRenderMode()
    .AddWebAssemblyRenderMode();

app.MapControllers();

app.Run();
