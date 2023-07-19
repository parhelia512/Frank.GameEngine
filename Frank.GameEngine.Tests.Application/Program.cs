using Frank.GameEngine.Tests.Application;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services => { services.AddHostedService<ConsoleRendererWorker>(); })
    .Build();

host.Run();