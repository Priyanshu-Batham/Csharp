namespace MenuPropsExplore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MDIParent1 p = new MDIParent1();
            p.ShowDialog();
        }
    }
}
