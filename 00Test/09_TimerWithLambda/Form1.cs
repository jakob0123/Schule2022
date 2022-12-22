namespace _09_TimerWithLambda
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
            //Events als Lambda Expression
            this.btnStart.Click += (sender, e) => this.timer.Start();
            this.btnStop.Click += (sender, e) => this.timer.Stop();
            this.timer.Tick += (sender, e) => this.txt_count.Text = this.counter++.ToString();
        }
    }
}