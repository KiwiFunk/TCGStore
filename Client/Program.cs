using Client;
using Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Blazor uses HttpClient to interact with the APIs
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7237/") // Localhost URL for the server
});

//Register services for dependency injection
builder.Services.AddScoped<CardService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<FeaturedProductService>();

await builder.Build().RunAsync();