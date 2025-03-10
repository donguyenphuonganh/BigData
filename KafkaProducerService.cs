using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
namespace SPX_Clone.Services;

public class KafkaProducerService
{
    private readonly string _bootstrapServers;
    private readonly string _topic;

    public KafkaProducerService(IConfiguration configuration)
    {
        _bootstrapServers = configuration["Kafka:BootstrapServers"];
        _topic = configuration["Kafka:Topic"];
    }

    public async Task SendMessageAsync(string message)
    {
        var config = new ProducerConfig { BootstrapServers = _bootstrapServers };

        using (var producer = new ProducerBuilder<Null, string>(config).Build())
        {
            var result = await producer.ProduceAsync(_topic, new Message<Null, string> { Value = message });
            Console.WriteLine($"Sent: {result.Value} to {result.TopicPartitionOffset}");
        }
    }
}
