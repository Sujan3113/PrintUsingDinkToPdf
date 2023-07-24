// See https://aka.ms/new-console-template for more information
using GCSjson;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");
using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((ctx, services) =>
    {
        services.AddDbContext<AppDbContext>();
        services.AddScoped<IGcsService, GcsService>();
    })
    .Build();
var data=host.Services.GetRequiredService<IGcsService>();
await data.GetGcs();