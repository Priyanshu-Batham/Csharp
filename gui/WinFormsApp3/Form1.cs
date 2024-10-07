namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("lucknow");
            listBox1.Items.Add("mumbai");
            listBox1.Items.Add("delhi");
            listBox1.Items.Add("goa");

            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Text = "hi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                comboBox1.Items.Add(item);
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<object> selectedItems = new List<object>();
            foreach (var item in listBox1.SelectedItems)
            {
                selectedItems.Add(item);
            };

            foreach (var item in selectedItems)
            {
                listBox1.Items.Remove(item);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
