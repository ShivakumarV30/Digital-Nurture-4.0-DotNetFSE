using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Confluent.Kafka;

namespace KafkaChatClient
{
    public partial class Form1 : Form
    {
        private TextBox txtMessages;
        private Button btnStart;

        public Form1()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Kafka Chat Client";
            this.Width = 500;
            this.Height = 400;

            txtMessages = new TextBox()
            {
                Multiline = true,
                Width = 450,
                Height = 280,
                Top = 10,
                Left = 10,
                ScrollBars = ScrollBars.Vertical
            };

            btnStart = new Button()
            {
                Text = "Start Listening",
                Width = 120,
                Height = 30,
                Top = 300,
                Left = 10
            };
            btnStart.Click += BtnStart_Click;

            this.Controls.Add(txtMessages);
            this.Controls.Add(btnStart);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Task.Run(() => StartKafkaConsumer());
        }

        private void StartKafkaConsumer()
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = "localhost:9092",
                GroupId = "chat-consumer-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
            consumer.Subscribe("chat-topic");

            while (true)
            {
                var cr = consumer.Consume();
                AppendMessage(cr.Message.Value);
            }
        }

        private void AppendMessage(string message)
        {
            if (txtMessages.InvokeRequired)
            {
                txtMessages.Invoke(new Action(() => txtMessages.AppendText(message + Environment.NewLine)));
            }
            else
            {
                txtMessages.AppendText(message + Environment.NewLine);
            }
        }
    }
}
