using Confluent.Kafka;

var config = new ConsumerConfig
{
    BootstrapServers = "localhost:9092",
    GroupId = "chat-group-1",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

Console.WriteLine("🟢 Kafka Chat Consumer Started...");
using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
consumer.Subscribe("chat-topic");

try
{
    while (true)
    {
        var cr = consumer.Consume();
        Console.WriteLine($"👤 Received: {cr.Message.Value}");
    }
}
catch (OperationCanceledException)
{
    consumer.Close();
}
