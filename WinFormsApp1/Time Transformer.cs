namespace WinFormsApp1
{
    public partial class TimeTransformer : Form
    {
        public TimeTransformer()
        {
            InitializeComponent();
        }

        private void TimeTransformer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string timestamp10 = this.textBox1.Text;
            string timestamp13 = this.textBox2.Text;
            string ticks = this.textBox4.Text;
            List<string> list = new List<string>();
            list.Add(timestamp10);
            list.Add(timestamp13);
            list.Add(ticks);
            if (list.All(s => string.IsNullOrEmpty(s)))
            {
                MessageBox.Show("请输入时间戳！",
                                  "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (list.Count(s => !string.IsNullOrEmpty(s)) != 1)
            {
                MessageBox.Show("请输入一种时间戳！",
                                  "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime dateTime = DateTime.Now;
            if (!string.IsNullOrEmpty(timestamp10))
            {
                dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(long.Parse(timestamp10));
            }
            if (!string.IsNullOrEmpty(timestamp13))
            {
                dateTime = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(timestamp13)).DateTime;
            }
            if (!string.IsNullOrEmpty(ticks))
            {
                dateTime = new DateTime(long.Parse(ticks));
            }
            this.dateTimePicker1.Value = dateTime;

            this.dateTimePicker2.Value = TimeZone.CurrentTimeZone.ToLocalTime(dateTime);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime time = this.dateTimePicker1.Value;

            DateTime startTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            long timestamp10 = (long)(time - startTime).TotalSeconds;
            this.textBox1.Text = timestamp10.ToString();

            long timestamp13 = (long)(time - startTime).TotalMilliseconds;
            this.textBox2.Text = timestamp13.ToString();


            long ticks = time.Ticks;
            this.textBox4.Text = ticks.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox4.Text = "";
        }
    }
}