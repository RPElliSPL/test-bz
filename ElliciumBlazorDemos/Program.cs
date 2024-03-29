using System;
using System.Net.Http;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

using ElliciumBlazorDemos.Services;
using Ellicium;
using ElliciumBlazorDemos.Data;
using ElliciumBlazorDemos;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddDbContextFactory<NorthwindContext>();

builder.Services.AddElliciumComponents();

builder.Services.AddScoped<ThemeService>();
builder.Services.AddScoped<CompilerService>();
builder.Services.AddScoped<ExampleService>();
builder.Services.AddScoped<NorthwindService>();
builder.Services.AddScoped<NorthwindODataService>();
builder.Services.AddSingleton<GitHubService>();

await builder.Build().RunAsync();