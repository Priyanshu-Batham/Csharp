using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form2 : Form
    {

        SqlDataReader reader;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Sql sql = new Sql();
            reader = sql.getAllEmployee();

            while (reader.Read()) //fetches one record at a time from the entire select query result and moves forward
            {
                comboBox1.Items.Add($"{reader["id"]}");
                listBox1.Items.Add($"{reader["id"]}");
            }
            reader.Close();
            sql.CloseConnection();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listBox1.Text);
            Sql sql = new Sql();

            reader = sql.getEmployee(id);

            if (reader.Read()) //this step is necessary as initially the reader points to null i.e. before the first record
            {

                textBox1.Text = reader["id"].ToString();
                textBox2.Text = reader["email"].ToString();
                textBox3.Text = reader["name"].ToString();
                textBox4.Text = reader["address"].ToString();
                textBox5.Text = reader["role"].ToString();
            }

            sql.CloseConnection();
            reader.Close();

            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox1.Text);
            Sql sql = new Sql();

            reader = sql.getEmployee(id);

            if (reader.Read()) //this step is necessary as initially the reader points to null i.e. before the first record
            {

                textBox1.Text = reader["id"].ToString();
                textBox2.Text = reader["email"].ToString();
                textBox3.Text = reader["name"].ToString();
                textBox4.Text = reader["address"].ToString();
                textBox5.Text = reader["role"].ToString();
            }

            sql.CloseConnection();
            reader.Close();
        }

        //update trigger
        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listBox1.Text);
            string email = textBox2.Text;
            string name = textBox3.Text;
            string address = textBox4.Text;
            string role = textBox5.Text;

            Sql sql = new Sql();
            sql.updateEmployee(id, email, name, address, role);
            label6.Text = "Employee updated successfully";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(listBox1.Text);
            Sql sql = new Sql();
            sql.deleteEmployee(id);
            label6.Text = "Employee deleted successfully";
        }
    }
}
