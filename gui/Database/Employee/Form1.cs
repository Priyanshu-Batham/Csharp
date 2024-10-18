using Microsoft.Data.SqlClient;
using System.Data;

namespace Employee
{
    public partial class Form1 : Form
    {
        SqlDataReader reader;
        Sql sql;


        public Form1()
        {
            InitializeComponent();
            sql = new Sql();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string email = textBox2.Text;
            string name = textBox3.Text;
            string address = textBox4.Text;
            string role = textBox5.Text;

            if (id == "" || email == "" || name == "" || address == "" || role == "")
            {
                label7.Text = "Fill All details";
                return;
            }

            try
            {
                sql.insertEmployee(Convert.ToInt32(id), email, name, address, role);
                label7.Text = "Employee added successfully";
            }
            catch (Exception ex)
            {
                label7.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }

    //utitlity class for handling Sql CRUD
    public class Sql
    {
        private SqlConnection conn;
        SqlCommand cmd;

        public Sql()
        {
            conn = new SqlConnection("Data Source=PRIYANSHU\\SQLEXPRESS;Initial Catalog=first;Integrated Security=True;Trust Server Certificate=True");
            cmd = new SqlCommand();
        }

        //Create
        public void insertEmployee(int id, string email, string name, string address, string role)
        {
            cmd = new SqlCommand($"insert into employee (id, email, name, address, role) values ({id}, '{email}', '{name}', '{address}', '{role}');", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close(); //here I can immediately close connection as there's no SqlDataReader associated with it
        }

        //Read
        public SqlDataReader getEmployee(int id)
        {
            cmd = new SqlCommand($"select * from employee where id = {id}", conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            //conn.Close();  If I close it here, the dataReader also closes immediately so I made a CloseConnection() fun
            return dataReader;
        }

        public SqlDataReader getAllEmployee()
        {
            cmd = new SqlCommand($"select * from employee;", conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            //conn.Close();
            return dataReader;
        }

        public void CloseConnection() //This fun will be executed by function that uses this Sql class
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close(); // Close the connection safely
            }
        }

    }
}
