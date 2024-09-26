namespace DynamicControls
{
    public partial class MathSelectForm : Form
    {
        public static string operation;
        public MathSelectForm()
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
            MathsOperationForm form = new MathsOperationForm();
            form.ShowDialog();
        }
    }
}
