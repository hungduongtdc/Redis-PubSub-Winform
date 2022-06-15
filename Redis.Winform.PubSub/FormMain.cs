using StackExchange.Redis;

namespace Redis.Winform.PubSub
{
    public partial class FormMain : Form
    {
        private ConnectionMultiplexer _redisConnection;
        private ISubscriber _subcriber;

        private bool subcribing = false;
        public FormMain()
        {
            InitializeComponent();
        }
        object lockObject = new object();
        private void btnSubcribe_Click(object sender, EventArgs e)
        {
            if (subcribing)
            {
                this._subcriber.UnsubscribeAll();
                this._redisConnection.Dispose();
                this.btnSubcribe.Text = "Subcribe";
            }
            else
            {
                this.btnSubcribe.Text = "Unsubcribe";

                this._redisConnection = ConnectionMultiplexer.Connect(this.txtRedisConnectionString.Text);
                this._subcriber = this._redisConnection.GetSubscriber();
                _subcriber.Subscribe(this.txtChannel.Text, (c, m) =>
                {
                    lock (lockObject)
                    {
                        this.txtMessages.Invoke(() =>
                        {

                            this.txtMessages.Text =
                            $"{this.txtMessages.Text}{Environment.NewLine}{m.ToString()}";
                        });
                    }
                });
            }
            subcribing = !subcribing;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}