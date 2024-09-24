namespace RuntimeCreationComponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating instance of a TextBox class
            TextBox t1 = new TextBox(); //TextBox is a class present in dll files
            t1.Location = new Point(118, 90); //x:150, y:150
            t1.BackColor = Color.Red;
            t1.Text = "Hello NPGC";
            this.Controls.Add(t1); //this referes to form object in which we are adding the textbox t1
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Adding items in combobox
            comboBox1.Items.Add("Lucknow");
            comboBox1.Items.Add("Delhi");
            comboBox1.Items.Add("Mumbai");
            comboBox1.Items.Add("Sultanpur");
            comboBox1.Items.Add("Goa");
            comboBox1.Items.Add("abc");
            comboBox1.Items.Add("Kolkata");
            comboBox1.Items.Add("Agra");
            comboBox1.Items.Add("Noida");


            comboBox2.Items.Add("Lucknow");
            comboBox2.Items.Add("Delhi");
            comboBox2.Items.Add("Mumbai");
            comboBox2.Items.Add("Sultanpur");
        }

        //When combobox value is changed this event is fired
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Extracting text from combobox
            textBox1.Text = comboBox1.Text;
            string x = textBox1.Text;

            if (x == "Lucknow")
            {
                textBox1.Text = "My City";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") comboBox1.Items.Add(textBox1.Text);
        }

        //Removing items
        private void button3_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Remove(comboBox1.Text);
            comboBox1.Items.Clear();
        }

        //Move One item to right
        private void button4_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Add(comboBox2.Text);
            comboBox2.Items.Remove(comboBox2.Text);
        }

        //Move One item to left
        private void button5_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(comboBox3.Text);
            comboBox3.Items.Remove(comboBox3.Text);
        }

        //Move All items to right
        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var item in comboBox2.Items)
            {
                comboBox3.Items.Add(item);
            }
            comboBox2.Items.Clear();
        }

        //Move All items to Left
        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var item in comboBox3.Items)
            {
                comboBox2.Items.Add(item);
            }
            comboBox3.Items.Clear();
        }
    }
}
