namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int textbox1data = Convert.ToInt32(textBox1.Text);
                int textbox2data = Convert.ToInt32(textBox2.Text);
                int sum = textbox1data + textbox2data;
                textBox3.Text = sum.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Red;
        }
    }
}
