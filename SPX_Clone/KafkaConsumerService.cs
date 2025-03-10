using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

public class KafkaConsumerService : BackgroundService
{
    private readonly string _bootstrapServers;
    private readonly string _topic;
    private readonly string _groupId = "aspnetcore-consumer";

    public KafkaConsumerService(IConfiguration configuration)
    {
        _bootstrapServers = configuration["Kafka:BootstrapServers"];
        _topic = configuration["Kafka:Topic"];
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = _bootstrapServers,
            GroupId = _groupId,
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using (var consumer = new ConsumerBuilder<Ignore, string>(config).Build())
        {
            consumer.Subscribe(_topic);

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var consumeResult = consumer.Consume(stoppingToken);
                    Console.WriteLine($"Received: {consumeResult.Message.Value}");
                }
                catch (OperationCanceledException)
                {
                    break;
                }
            }

            consumer.Close();
        }
    }
}
