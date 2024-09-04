using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Puzzle_48.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(http => new HttpClient
{
	BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});
builder.Services.AddScoped<IEpisodeClient, EpisodeClient>();

await builder.Build().RunAsync();
