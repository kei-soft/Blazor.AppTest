using Blazor.PrismTest;
using Blazor.PrismTest.ViewModels;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using Prism.Events;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// EventAggregator 종속성 주입
builder.Services.AddScoped<IEventAggregator, EventAggregator>();

builder.Services.AddScoped<MvvmVewModel>();

await builder.Build().RunAsync();
