using System.Text.Json;

namespace Workers.StockWorker;

public class Worker(ILogger<Worker> logger, IConfiguration configuration) : BackgroundService
{
    private readonly ILogger<Worker> _logger = logger;
    private readonly IConfiguration _configuration = configuration;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            await ExtractData(stoppingToken);

            await Task.Delay(TimeSpan.FromHours(1), stoppingToken);
        }
    }

    private async Task ExtractData(CancellationToken stoppingToken)
    {
        IConfigurationSection queryUrlKey = _configuration.GetSection("QueryUrl");

        if (queryUrlKey.Value is not null)
        {
            using HttpClient client = new();
            HttpResponseMessage data = await client.GetAsync(queryUrlKey.Value, stoppingToken);
            object? json_data = JsonSerializer.Deserialize<object>(await data.Content.ReadAsStringAsync(stoppingToken));

            _logger.LogInformation("Request send at: {time}", DateTimeOffset.Now);
            _logger.LogInformation("Data received: {data}", json_data);
        }
    }
}
