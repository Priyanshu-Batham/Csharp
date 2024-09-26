using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authentication
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Faculty");
            comboBox1.Items.Add("Student");

            foreach (var item in HomePageForm.UserData)
            {
                listBox1.Items.Add($"Roll: {item.rollno} | Name: {item.username} | Type: {item.userType}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            {
                label6.Text = "No empty fields allowed";
                return;
            }

            int rollNo = Convert.ToInt32(textBox3.Text);
            string username = textBox1.Text;
            string password = textBox2.Text;
            string userType = comboBox1.Text;

            foreach (var item in HomePageForm.UserData)
            {
                if(item.username == username || item.rollno == rollNo)
                {
                    label6.Text = "Take another username or rollno";
                    return;
                }
            }

            HomePageForm.UserData.Add(new User(userType, username, password, rollNo));
            label6.Text = "User Added Successfully";
        }
    }
}
