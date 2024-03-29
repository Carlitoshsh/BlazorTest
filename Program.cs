using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorTest;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var address = "https://pokeapi.co/api/v2/";
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(address) });

await builder.Build().RunAsync();
