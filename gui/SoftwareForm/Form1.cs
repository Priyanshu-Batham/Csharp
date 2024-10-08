namespace SoftwareForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Visible = !label2.Visible;
            if(progressBar1.Value < 100) progressBar1.Value++;
            else
            {
                timer1.Enabled = false;
                Login formLogin = new Login();
                formLogin.ShowDialog();
            }
        }
    }
}
