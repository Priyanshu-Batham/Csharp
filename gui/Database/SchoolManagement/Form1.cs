using System.Collections.Generic;
using System.Data.SqlClient;

namespace SchoolManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "123")
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else label4.Text = "Invalid Credentials";
        }
    }

    //-----------------------------------------DATABASE---------------------------------------->>>>
    //Sql class to handle all db CRUD
    public class Sql
    {
        private string _connString;
        public SqlConnection conn;
        public Sql()
        {
            _connString = "Data Source=PRIYANSHU\\SQLEXPRESS;Initial Catalog=SchoolManagement;Integrated Security=True;";
            conn = new SqlConnection(_connString);
        }

        public void createStudent(Student student)
        {
            string query = $"insert into Student (name, gender, address, phoneNo, course, semester, email) values ('{student.name}', '{student.gender.ToString()}', '{student.address}', '{student.phoneNo}', '{student.course.ToString()}', '{student.semester.ToString()}', '{student.email}');";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void createTeacher(Teacher teacher)
        {
            string query = $"insert into Teacher (name, gender, address, phoneNo, email, subject, salary, department) values ('{teacher.name}', '{teacher.gender.ToString()}', '{teacher.address}', '{teacher.phoneNo}', '{teacher.email}', '{teacher.subject.ToString()}', {teacher.salary}, '{teacher.department.ToString()}');";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void createStaff(Staff staff)
        {
            string query = $"insert into staff (name, gender, address, phoneNo, email, salary, department, role) values ('{staff.name}', '{staff.gender.ToString()}', '{staff.address}', '{staff.phoneNo}', '{staff.email}', {staff.salary}, '{staff.department.ToString()}', '{staff.role.ToString()}');";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //overloaded functions for getStudent
        //overload 1
        public Student? getStudent(int id)
        {
            string query = $"select * from Student where id = {id};";
            SqlCommand cmd = new SqlCommand (query, conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                string name = dataReader["name"].ToString()!;
                Gender gender = (Gender) Enum.Parse(typeof(Gender), dataReader["gender"].ToString()!);
                string address = dataReader["address"].ToString()!;
                string phoneNo = dataReader["phoneNo"].ToString()!;
                Course course = (Course)Enum.Parse(typeof(Course), dataReader["course"].ToString()!);
                Semester semester = (Semester)Enum.Parse(typeof(Semester), dataReader["semester"].ToString()!);
                string email = dataReader["email"].ToString()!;

                Student student = new Student(name!, gender, address!, phoneNo!, course, semester, email!);
                student.id = id.ToString();
                return student;

            }
            else return null;
        }
        //overload 2
        public Student? getStudent(String name)
        {
            string query = $"select * from Student where name = '{name}';";
            SqlCommand cmd = new SqlCommand (query, conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                string id = dataReader["id"].ToString()!;
                Gender gender = (Gender) Enum.Parse(typeof(Gender), dataReader["gender"].ToString()!);
                string address = dataReader["address"].ToString()!;
                string phoneNo = dataReader["phoneNo"].ToString()!;
                Course course = (Course)Enum.Parse(typeof(Course), dataReader["course"].ToString()!);
                Semester semester = (Semester)Enum.Parse(typeof(Semester), dataReader["semester"].ToString()!);
                string email = dataReader["email"].ToString()!;

                Student student = new Student(name!, gender, address!, phoneNo!, course, semester, email!);
                student.id = id.ToString();
                return student;

            }
            else return null;
        }
        //overload 3
        public List<Student>? getStudent(Course course)
        {
            List<Student> students = new List<Student>();
            string query = $"select * from Student where course = '{course.ToString()}';";
            SqlCommand cmd = new SqlCommand (query, conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    string id = dataReader["id"].ToString()!;
                    string name = dataReader["name"].ToString()!;
                    Gender gender = (Gender)Enum.Parse(typeof(Gender), dataReader["gender"].ToString()!);
                    string address = dataReader["address"].ToString()!;
                    string phoneNo = dataReader["phoneNo"].ToString()!;
                    Semester semester = (Semester)Enum.Parse(typeof(Semester), dataReader["semester"].ToString()!);
                    string email = dataReader["email"].ToString()!;

                    Student student = new Student(name!, gender, address!, phoneNo!, course, semester, email!);
                    student.id = id.ToString();
                    students.Add(student);
                }
                
                return students;

            }
            else return null;
        }
        
        //overloaded functions for getTeacher
        //overload 1
        public Teacher? getTeacher(int id)
        {
            string query = $"select * from Teacher where id = {id};";
            SqlCommand cmd = new SqlCommand (query, conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                string name = dataReader["name"].ToString()!;
                Gender gender = (Gender) Enum.Parse(typeof(Gender), dataReader["gender"].ToString()!);
                string address = dataReader["address"].ToString()!;
                string phoneNo = dataReader["phoneNo"].ToString()!;
                string email = dataReader["email"].ToString()!;
                Subject subject = (Subject)Enum.Parse(typeof(Subject), dataReader["subject"].ToString()!);
                int salary = Convert.ToInt32(dataReader["salary"]);
                Department department = (Department)Enum.Parse(typeof(Department), dataReader["department"].ToString()!);

                Teacher teacher = new Teacher(name!, gender, address!, phoneNo!, email, subject, salary, department);
                teacher.id = id.ToString();
                return teacher;

            }
            else return null;
        }
        //overload 2
        public Teacher? getTeacher(String name)
        {
            string query = $"select * from Teacher where name = '{name}';";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                int id = Convert.ToInt32(dataReader["id"]);
                Gender gender = (Gender)Enum.Parse(typeof(Gender), dataReader["gender"].ToString()!);
                string address = dataReader["address"].ToString()!;
                string phoneNo = dataReader["phoneNo"].ToString()!;
                string email = dataReader["email"].ToString()!;
                Subject subject = (Subject)Enum.Parse(typeof(Subject), dataReader["subject"].ToString()!);
                int salary = Convert.ToInt32(dataReader["salary"]);
                Department department = (Department)Enum.Parse(typeof(Department), dataReader["department"].ToString()!);

                Teacher teacher = new Teacher(name!, gender, address!, phoneNo!, email, subject, salary, department);
                teacher.id = id.ToString();
                return teacher;

            }
            else return null;
        }
        //overload 3
        public List<Teacher>? getTeacher(Department department)
        {
            List<Teacher> teachers = new List<Teacher>();
            string query = $"select * from Teacher where department = '{department.ToString()}';";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader["id"]);
                    String name = dataReader["name"].ToString()!;
                    Gender gender = (Gender)Enum.Parse(typeof(Gender), dataReader["gender"].ToString()!);
                    string address = dataReader["address"].ToString()!;
                    string phoneNo = dataReader["phoneNo"].ToString()!;
                    string email = dataReader["email"].ToString()!;
                    Subject subject = (Subject)Enum.Parse(typeof(Subject), dataReader["subject"].ToString()!);
                    int salary = Convert.ToInt32(dataReader["salary"]);

                    Teacher teacher = new Teacher(name!, gender, address!, phoneNo!, email, subject, salary, department);
                    teacher.id = id.ToString();
                    teachers.Add(teacher);
                }
                return teachers;

            }
            else return null;
        }
        
        //overloaded functions for getStaff
        //overload 1
        public Staff? getStaff(int id)
        {
            string query = $"select * from Staff where id = {id};";
            SqlCommand cmd = new SqlCommand (query, conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                string name = dataReader["name"].ToString()!;
                Gender gender = (Gender) Enum.Parse(typeof(Gender), dataReader["gender"].ToString()!);
                string address = dataReader["address"].ToString()!;
                string phoneNo = dataReader["phoneNo"].ToString()!;
                string email = dataReader["email"].ToString()!;
                int salary = Convert.ToInt32(dataReader["salary"]);
                Department department = (Department)Enum.Parse(typeof(Department), dataReader["department"].ToString()!);
                Role role = (Role) Enum.Parse(typeof(Role), dataReader["role"].ToString()!);

                Staff staff = new Staff(name!, gender, address!, phoneNo!, email, salary, department, role);
                staff.id = id.ToString();
                return staff;

            }
            else return null;
        }
        //overload 2
        public Staff? getStaff(String name)
        {
            string query = $"select * from Staff where name = '{name}';";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Read();
                int id = Convert.ToInt32(dataReader["id"]);
                Gender gender = (Gender)Enum.Parse(typeof(Gender), dataReader["gender"].ToString()!);
                string address = dataReader["address"].ToString()!;
                string phoneNo = dataReader["phoneNo"].ToString()!;
                string email = dataReader["email"].ToString()!;
                int salary = Convert.ToInt32(dataReader["salary"]);
                Department department = (Department)Enum.Parse(typeof(Department), dataReader["department"].ToString()!);
                Role role = (Role)Enum.Parse(typeof(Role), dataReader["role"].ToString()!);

                Staff staff = new Staff(name!, gender, address!, phoneNo!, email, salary, department, role);
                staff.id = id.ToString();
                return staff;

            }
            else return null;
        }
        //overload 3
        public List<Staff>? getStaff(Role role)
        {
            List<Staff> staffs = new List<Staff>();
            string query = $"select * from Staff where role = '{role.ToString()}';";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader["id"]);
                    String name = dataReader["name"].ToString()!;
                    Gender gender = (Gender)Enum.Parse(typeof(Gender), dataReader["gender"].ToString()!);
                    string address = dataReader["address"].ToString()!;
                    string phoneNo = dataReader["phoneNo"].ToString()!;
                    string email = dataReader["email"].ToString()!;
                    int salary = Convert.ToInt32(dataReader["salary"]);
                    Department department = (Department)Enum.Parse(typeof(Department), dataReader["department"].ToString()!);

                    Staff staff = new Staff(name!, gender, address!, phoneNo!, email, salary, department, role);
                    staff.id = id.ToString();
                    staffs.Add(staff);
                }
                return staffs;

            }
            else return null;
        }
    }

    //-----------------------------------------SCHEMAS---------------------------------------->>>>
    //Schema classes for corresponding tables in db
    public class Student {
        public string? id;
        public string name;
        public Gender gender;
        public string address;
        public string phoneNo;
        public Course course;
        public Semester semester;
        public string email;

        //constructor
        public Student(string name, Gender gender, string address, string phoneNo, Course course, Semester semester, string email)
        {
            this.name = name;
            this.gender = gender;
            this.address = address;
            this.phoneNo = phoneNo;
            this.course = course;
            this.semester = semester;
            this.email = email;
        }
    }
    public class Teacher
    {
        public string? id;
        public string name;
        public Gender gender;
        public string address;
        public string phoneNo;
        public string email;
        public Subject subject;
        public int salary;
        public Department department;

        //constructor
        public Teacher(string name, Gender gender, string address, string email, string phoneNo, Subject subject, int salary, Department department)
        {
            this.name = name;
            this.gender = gender;
            this.address = address;
            this.email = email;
            this.phoneNo = phoneNo;
            this.subject = subject;
            this.salary = salary;
            this.department = department;
        }
    }
    public class Staff
    {
        public string? id;
        public string name;
        public Gender gender;
        public string address;
        public string phoneNo;
        public string email;
        public int salary;
        public Department department;
        public Role role;

        //constructor
        public Staff(string name, Gender gender, string address, string phoneNo, string email, int salary, Department department, Role role)
        {
            this.name = name;
            this.gender = gender;
            this.address = address;
            this.email = email;
            this.phoneNo = phoneNo;
            this.department = department;
            this.salary = salary;
            this.role = role;
        }
    }

    //-----------------------------------------MISC---------------------------------------->>>>
    //Custom Exception for form validations
    public class ValidationError : Exception
    {
        public ValidationError(string message) : base(message)
        {
        }

        //method to check if phone number is valid
        public static void CheckValidPhNo(string number)
        {
            if (number.Length != 10) throw new ValidationError("Phone number length should be 10 digits"); 
            if(! number.All(char.IsDigit)) throw new ValidationError("Invalid Number");
        }
    }




    //enum for constant values
    public enum Gender
    {
        Male,
        Female
    }

    public enum Department { 
        ComputerScience,
        Commerce,
        Arts,
        Science,
        Journalism
    }

    public enum Role {
        LabAssistant,
        Sweeper,
        Security,
        Helper
    }

    public enum Subject { 
        Csharp,
        Python,
        Maths,
        History,
        Biology,
        Chemistry,
        Geography,
        Physics,
        Accountancy,
        SoftwareEngineering
    }


    public enum Semester
    {
        First,
        Second,
        Third,
        Fourth,
        Fifth,
        Sixth
    }

    public enum Course
    {
        BCA,
        BBA,
        BVOC,
        BTECH,
        BJMC
    }
}