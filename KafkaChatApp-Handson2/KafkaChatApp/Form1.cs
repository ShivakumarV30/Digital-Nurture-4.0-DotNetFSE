using System;
using System.Windows.Forms;
using Confluent.Kafka;
using System.Threading;
using System.Threading.Tasks;

namespace KafkaChatApp
{
    public partial class Form1 : Form
    {
        private const string bootstrapServers = "localhost:9092";
        private const string topic = "chat-topic";
        private IProducer<Null, string> producer;

        public Form1()
        {
            InitializeComponent();

            var config = new ProducerConfig { BootstrapServers = bootstrapServers };
            producer = new ProducerBuilder<Null, string>(config).Build();

            // Start consumer in background
            Task.Run(() => StartConsumer());
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            var message = txtMessage.Text;
            if (!string.IsNullOrEmpty(message))
            {
                await producer.ProduceAsync(topic, new Message<Null, string> { Value = message });
                txtMessage.Clear();
            }
        }

        private void StartConsumer()
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = bootstrapServers,
                GroupId = Guid.NewGuid().ToString(),
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using (var consumer = new ConsumerBuilder<Ignore, string>(config).Build())
            {
                consumer.Subscribe(topic);

                while (true)
                {
                    var result = consumer.Consume(CancellationToken.None);
                    Invoke(new Action(() =>
                    {
                        lstMessages.Items.Add("Received: " + result.Message.Value);
                    }));
                }
            }
        }
    }
}
