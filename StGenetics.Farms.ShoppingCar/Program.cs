using Blazored.Toast;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StGenetics.Farms.ShoppingCar;
using StGenetics.Farms.ShoppingCar.Models;
using StGenetics.Farms.ShoppingCar.Services.Contracts;
using StGenetics.Farms.ShoppingCar.Services.Implements;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Custom Services
builder.Services.AddTransient<IService<Animal>, AnimalService>();
builder.Services.AddScoped<IDataTransferService<Animal>, AnimalShoppingTransferService>();

// External pacakges
builder.Services.AddBlazoredToast();

await builder.Build().RunAsync();
