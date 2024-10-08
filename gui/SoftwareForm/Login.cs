using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            if(username == "priyanshu" && password == "123")
            {
                NotepadForm notepadForm = new NotepadForm();
                notepadForm.ShowDialog();
            }
            else
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Invalid Credentials";
            }

        }
    }
}
