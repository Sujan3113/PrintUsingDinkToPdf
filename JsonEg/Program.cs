// See https://aka.ms/new-console-template for more information
using JsonEg;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");
using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((ctx, services) =>
    {
        services.AddDbContext<EFDbContext>();
        services.AddScoped<IEmployeeService, EmployeeService>();
    })
    .Build();

var employees = host.Services.GetRequiredService<IEmployeeService>();
await employees.GetEmployee();