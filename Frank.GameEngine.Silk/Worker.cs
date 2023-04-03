using System.Numerics;

namespace Frank.GameEngine.Silk;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var silk = new SilkProgram();
        
        silk.Start();
    }
}