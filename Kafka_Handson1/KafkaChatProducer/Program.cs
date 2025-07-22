using Confluent.Kafka;

Console.WriteLine("🔵 Kafka Chat Producer Started...");
var config = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};

using var producer = new ProducerBuilder<Null, string>(config).Build();

while (true)
{
    Console.Write("You: ");
    string? message = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(message))
    {
        await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
        Console.WriteLine("✅ Message sent!");
    }
}
