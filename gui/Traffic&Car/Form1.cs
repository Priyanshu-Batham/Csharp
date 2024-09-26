namespace Traffic_Car
{
    public partial class Form1 : Form
    {
        private int tick1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer1.Interval = 1000;
            timer2.Interval = 10;

            tick1 = -1; //so that first value comes out to be 0
        }

        //timer for traffic lights
        private void timer1_Tick(object sender, EventArgs e)
        {
            tick1 = (tick1 + 1) % 3;
            //default
            label1.ForeColor = Color.Black;
            label1.BackColor = Color.White;
            label2.ForeColor = Color.Black;
            label2.BackColor = Color.White;
            label3.ForeColor = Color.Black;
            label3.BackColor = Color.White;

            //Red
            if (tick1 == 0)
            {
                label1.ForeColor = Color.White;
                label1.BackColor = Color.Red;
            }
            //Yellow
            else if (tick1 == 1)
            {
                label2.ForeColor = Color.White;
                label2.BackColor = Color.Yellow;
            }
            //Green
            else if (tick1 == 2)
            {
                label3.ForeColor = Color.White;
                label3.BackColor = Color.Green;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (tick1 != 2) return; //move the car only on green signal
            int x = label4.Location.X;
            x = (x + 1) % this.Width; //this.width means form1.width
            label4.Location = new Point(x, label4.Location.Y); 
        }
    }
}
