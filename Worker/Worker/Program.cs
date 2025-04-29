var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Workers.StockWorker.Worker>();

var host = builder.Build();
host.Run();
