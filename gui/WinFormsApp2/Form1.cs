namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Database db;
        int id;
        public Form1()
        {
            InitializeComponent();
            db = new Database();
            id = 0;
            lblAddUser.Visible = false;
            lblError.Visible = false;
        }

        //Add User
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            bool res = db.addUser(new User(id.ToString(), username, password));
            lblAddUser.Visible = true;
            if (res)
            {
                lblAddUser.ForeColor = Color.Green;
                lblAddUser.Text = "New User Added";
            }
            else
            {
                lblAddUser.ForeColor = Color.DarkRed;
                lblAddUser.Text = "No more space";
            }
        }

        //Login 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtUserpassword.Text;
            lblError.Visible = true;
            if (db.isValid(username, password))
            {
                lblError.ForeColor = Color.Green;
                lblError.Text = "Successfully Logged In";
            }
            else
            {
                lblError.ForeColor = Color.DarkRed;
                lblError.Text = "Invalid Credentials";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();  //UI remains, but it is closed in memory
        }
    }
    //User class
    public class User
    {
        public string id;
        public string name;
        public string password;

        public User(string id, string name, string password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }
    }

    public class Database
    {
        User[] data;
        int ptr;
        public Database()
        {
            data = new User[2];
            ptr = 0;
        }

        public bool addUser(User user)
        {
            if (ptr == data.Length) return false;
            data[ptr++] = user;
            return true;
        }

        public bool isValid(String name, String password)
        {
            
            for (int i = 0; i < ptr; i++)
            {
                if (data[i].name == name && data[i].password == password)
                {
                    return true;
                }      
            }
            return false;
        }
    }    
}
