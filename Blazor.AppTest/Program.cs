using Blazor.AppTest;
using Blazor.AppTest.Data;
using Blazor.AppTest.Services;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<WeatherForecastService>();

// Register the pizzas service
builder.Services.AddSingleton<PizzaService>();

await builder.Build().RunAsync();
