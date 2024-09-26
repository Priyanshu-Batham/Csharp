namespace DynamicControls
{
    public partial class DynoForm1 : Form
    {
        public static string operation;
        public DynoForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Min");
            comboBox1.Items.Add("Max");
            comboBox1.Items.Add("Square");
            comboBox1.Items.Add("Power");
            comboBox1.Items.Add("Absolute");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") return;
            operation = comboBox1.Text;
            MathsForm form = new MathsForm();
            form.ShowDialog();
        }
    }
}
