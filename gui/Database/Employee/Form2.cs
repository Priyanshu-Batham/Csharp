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
    }
}
