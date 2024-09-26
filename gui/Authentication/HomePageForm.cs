using DynamicControls;

namespace Authentication
{
    public partial class HomePageForm : Form
    {
        public static string userType;
        public static User userAdmin = new User("Admin", "admin", "admin", 69);
        public static List<User> UserData = new List<User>();

        public HomePageForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Faculty");
            comboBox1.Items.Add("Student");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userType = comboBox1.Text;
            string login = textBox1.Text;
            string password = textBox2.Text;

            //For Admin
            if (userType == "Admin")
            {
                if (login == userAdmin.username && password == userAdmin.password)
                {
                    RegistrationForm registrationForm = new RegistrationForm();
                    registrationForm.ShowDialog();
                    return;
                }
                else
                {
                    label5.Text = "Invalid Credentials";
                }
            }

            //For Others
            else
            {
                foreach (var item in UserData)
                {
                    if (item.username == login && item.password == password)
                    {
                        //for students
                        if (item.userType == "Student")
                        {
                            MathSelectForm mathSelectForm = new MathSelectForm();
                            mathSelectForm.ShowDialog();
                            return;
                        }
                        //for faculty
                        else if (item.userType == "Faculty")
                        {
                            TextSelectForm textSelectForm = new TextSelectForm();
                            textSelectForm.ShowDialog();
                            return;
                        }
                    }
                }
                label5.Text = "Invalid Credentials";
                return;
            }
        }
    }

    //User class
    public class User
    {
        public string userType;
        public string username;
        public string password;
        public int rollno;

        public User(string userType, string username, string password, int rollno)
        {
            this.userType = userType;
            this.username = username;
            this.password = password;
            this.rollno = rollno;
        }
    }
}
