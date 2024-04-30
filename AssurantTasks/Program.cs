using AssurantTasks.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args)
    .ConfigureServices((c, s) =>
    {
        s.AddSingleton<ITicTac, TicTac>();
    })
    .Build();

var ticTac = builder.Services.GetRequiredService<ITicTac>();

ticTac.PrintTicTac();
