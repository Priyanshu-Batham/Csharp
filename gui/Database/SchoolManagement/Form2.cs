using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //adding gender to combobox
            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                comboBox1.Items.Add(item);
                comboBox6.Items.Add(item);
                comboBox9.Items.Add(item);
            }

            //adding course to combobox
            foreach (var item in Enum.GetValues(typeof(Course)))
            {
                comboBox2.Items.Add(item);
                comboBox10.Items.Add(item);
            }

            //adding semester to combobox
            foreach (var item in Enum.GetValues(typeof(Semester)))
            {
                comboBox3.Items.Add(item);
            }

            //adding subject to combobox
            foreach (var item in Enum.GetValues(typeof(Subject)))
            {
                comboBox4.Items.Add(item);
            }

            //adding department to combobox
            foreach (var item in Enum.GetValues(typeof(Department)))
            {
                comboBox5.Items.Add(item);
                comboBox7.Items.Add(item);
                comboBox11.Items.Add(item);
            }

            //adding role to combobox
            foreach (var item in Enum.GetValues(typeof(Role)))
            {
                comboBox8.Items.Add(item);
                comboBox12.Items.Add(item);
            }

        }

        //Add Student
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                if (comboBox1.Text == "") throw new ValidationError("Select a Gender");
                Gender gender = (Gender)Enum.Parse(typeof(Gender), comboBox1.Text);
                string address = textBox2.Text;
                string phNo = textBox3.Text;
                ValidationError.CheckValidPhNo(phNo);
                if (comboBox2.Text == "") throw new ValidationError("Select a Course");
                Course course = (Course)Enum.Parse(typeof(Course), comboBox2.Text);
                if (comboBox3.Text == "") throw new ValidationError("Select a Semester");
                Semester semester = (Semester)Enum.Parse(typeof(Semester), comboBox3.Text);
                string email = textBox4.Text;

                if (name == "" || address == "" || phNo == "" || email == "") throw new ValidationError("Fill out all details");


                Sql sql = new Sql();
                sql.createStudent(new Student(name, gender, address, phNo, course, semester, email));
                label9.Text = "Student Added Successfully";
            }
            catch (SqlException sqlEx)
            {
                label9.Text = "Phone number or email already exists";
            }

            catch (Exception ex)
            {
                label9.Text = ex.Message;
            }
        }

        //Add Teacher
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox8.Text;
                if (comboBox6.Text == "") throw new ValidationError("Select a Gender");
                Gender gender = (Gender)Enum.Parse(typeof(Gender), comboBox6.Text);
                string address = textBox7.Text;
                string phNo = textBox6.Text;
                ValidationError.CheckValidPhNo(phNo);
                string email = textBox5.Text;
                if (comboBox4.Text == "") throw new ValidationError("Select a Subject");
                Subject subject = (Subject)Enum.Parse(typeof(Subject), comboBox4.Text);
                int salary = Convert.ToInt32(textBox9.Text);
                if (comboBox5.Text == "") throw new ValidationError("Select a Department");
                Department department = (Department)Enum.Parse(typeof(Department), comboBox5.Text);


                if (name == "" || address == "" || phNo == "" || email == "") throw new ValidationError("Fill out all details");


                Sql sql = new Sql();
                sql.createTeacher(new Teacher(name, gender, address, email, phNo, subject, salary, department));
                label10.Text = "Teacher Added Successfully";
            }
            catch (SqlException sqlEx)
            {
                label10.Text = "Phone number or email already exists";
            }

            catch (Exception ex)
            {
                label10.Text = ex.Message;
            }
        }

        //Add Staff
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox14.Text;
                if (comboBox9.Text == "") throw new ValidationError("Select a Gender");
                Gender gender = (Gender)Enum.Parse(typeof(Gender), comboBox9.Text);
                string address = textBox13.Text;
                string phNo = textBox12.Text;
                ValidationError.CheckValidPhNo(phNo);
                string email = textBox11.Text;
                int salary = Convert.ToInt32(textBox10.Text);
                if (comboBox7.Text == "") throw new ValidationError("Select a Department");
                Department department = (Department)Enum.Parse(typeof(Department), comboBox7.Text);
                if (comboBox8.Text == "") throw new ValidationError("Select a Role");
                Role role = (Role)Enum.Parse(typeof(Role), comboBox8.Text);


                if (name == "" || address == "" || phNo == "" || email == "") throw new ValidationError("Fill out all details");


                Sql sql = new Sql();
                sql.createStaff(new Staff(name, gender, address, phNo, email, salary, department, role));
                label21.Text = "Staff Member Added Successfully";
            }
            catch (SqlException sqlEx)
            {
                label21.Text = "Phone number or email already exists";
            }

            catch (Exception ex)
            {
                label21.Text = ex.Message;
            }
        }

        //seach student by id
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox19.Text);

                Sql sql = new Sql();
                Student? student = sql.getStudent(id);
                if (student == null) throw new ValidationError("No Student Found");

                textBox18.Text = student.name;
                textBox20.Text = student.gender.ToString();
                textBox17.Text = student.address;
                textBox16.Text = student.phoneNo.ToString();
                textBox21.Text = student.course.ToString();
                textBox22.Text = student.semester.ToString();
                textBox15.Text = student.email;
            }
            catch (Exception ex)
            {
                label30.Text = ex.Message;
            }
        }

        //seach student by Name
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBox26.Text;

                Sql sql = new Sql();
                Student? student = sql.getStudent(name);
                if (student == null) throw new ValidationError("No Student Found");

                textBox30.Text = student.id;
                textBox25.Text = student.gender.ToString();
                textBox29.Text = student.address;
                textBox28.Text = student.phoneNo.ToString();
                textBox24.Text = student.course.ToString();
                textBox23.Text = student.semester.ToString();
                textBox27.Text = student.email;
            }
            catch (Exception ex)
            {
                label41.Text = ex.Message;
            }
        }

        //seach students by course
        private void button6_Click(object sender, EventArgs e)
        {
            //clearing the results initially
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            try
            {
                Course course = (Course)Enum.Parse(typeof(Course), comboBox10.Text);

                Sql sql = new Sql();
                List<Student>? students = sql.getStudent(course);

                if (students == null) return;

                foreach (Student student in students)
                {
                    listBox1.Items.Add(student.id);
                    listBox2.Items.Add(student.name);
                    listBox3.Items.Add(student.gender.ToString());
                    listBox4.Items.Add(student.address);
                    listBox5.Items.Add(student.phoneNo.ToString());
                    listBox6.Items.Add(student.course.ToString());
                    listBox7.Items.Add(student.semester.ToString());
                    listBox8.Items.Add(student.email);
                }
            }
            catch (Exception ex)
            {
                //am not making any label for errors here since it will be fully under control
            }

        }

        //search teacher by id
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox34.Text);

                Sql sql = new Sql();
                Teacher? teacher = sql.getTeacher(id);
                if (teacher == null) throw new ValidationError("No Teacher Found");

                textBox38.Text = teacher.name;
                textBox33.Text = teacher.gender.ToString();
                textBox37.Text = teacher.address;
                textBox36.Text = teacher.phoneNo.ToString();
                textBox32.Text = teacher.email;
                textBox31.Text = teacher.subject.ToString();
                textBox35.Text = teacher.salary.ToString();
                textBox39.Text = teacher.department.ToString();
            }
            catch (Exception ex)
            {
                label64.Text = ex.Message;
            }
        }

        //search teacher by name
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox44.Text;

                Sql sql = new Sql();
                Teacher? teacher = sql.getTeacher(name);
                if (teacher == null) throw new ValidationError("No Teacher Found");

                textBox48.Text = teacher.id;
                textBox43.Text = teacher.gender.ToString();
                textBox47.Text = teacher.address;
                textBox46.Text = teacher.phoneNo.ToString();
                textBox42.Text = teacher.email;
                textBox41.Text = teacher.subject.ToString();
                textBox45.Text = teacher.salary.ToString();
                textBox40.Text = teacher.department.ToString();
            }
            catch (Exception ex)
            {
                label76.Text = ex.Message;
            }
        }

        //search teacher by department
        private void button9_Click(object sender, EventArgs e)
        {
            //clearing the results initially
            listBox16.Items.Clear();
            listBox15.Items.Clear();
            listBox14.Items.Clear();
            listBox13.Items.Clear();
            listBox12.Items.Clear();
            listBox9.Items.Clear();
            listBox11.Items.Clear();
            listBox10.Items.Clear();
            listBox17.Items.Clear();
            try
            {
                Department department = (Department)Enum.Parse(typeof(Department), comboBox11.Text);

                Sql sql = new Sql();
                List<Teacher>? teachers = sql.getTeacher(department);

                if (teachers == null) return;

                foreach (Teacher teacher in teachers)
                {
                    listBox16.Items.Add(teacher.id);
                    listBox15.Items.Add(teacher.name);
                    listBox14.Items.Add(teacher.gender.ToString());
                    listBox13.Items.Add(teacher.address);
                    listBox12.Items.Add(teacher.phoneNo.ToString());
                    listBox9.Items.Add(teacher.email);
                    listBox11.Items.Add(teacher.subject.ToString());
                    listBox10.Items.Add(teacher.email);
                    listBox17.Items.Add(teacher.department.ToString());

                }
            }
            catch (Exception ex)
            {
                //am not making any label for errors here since it will be fully under control
            }
        }

        //search staff by id
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox53.Text);

                Sql sql = new Sql();
                Staff? staff = sql.getStaff(id);
                if (staff == null) throw new ValidationError("No Staff Found");

                textBox57.Text = staff.name;
                textBox52.Text = staff.gender.ToString();
                textBox56.Text = staff.address;
                textBox55.Text = staff.phoneNo.ToString();
                textBox51.Text = staff.email;
                textBox54.Text = staff.salary.ToString();
                textBox49.Text = staff.department.ToString();
                textBox50.Text = staff.role.ToString();
            }
            catch (Exception ex)
            {
                label101.Text = ex.Message;
            }
        }

        //search staff by Name
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox62.Text;

                Sql sql = new Sql();
                Staff? staff = sql.getStaff(name);
                if (staff == null) throw new ValidationError("No Staff Found");

                textBox66.Text = staff.id;
                textBox61.Text = staff.gender.ToString();
                textBox65.Text = staff.address;
                textBox64.Text = staff.phoneNo.ToString();
                textBox60.Text = staff.email;
                textBox63.Text = staff.salary.ToString();
                textBox58.Text = staff.department.ToString();
                textBox59.Text = staff.role.ToString();
            }
            catch (Exception ex)
            {
                label112.Text = ex.Message;
            }
        }

        //search staff by role
        private void button12_Click(object sender, EventArgs e)
        {
            //clearing the results initially
            listBox26.Items.Clear();
            listBox25.Items.Clear();
            listBox24.Items.Clear();
            listBox23.Items.Clear();
            listBox22.Items.Clear();
            listBox19.Items.Clear();
            listBox21.Items.Clear();
            listBox20.Items.Clear();
            listBox18.Items.Clear();
            try
            {
                Role role = (Role)Enum.Parse(typeof(Role), comboBox12.Text);

                Sql sql = new Sql();
                List<Staff>? staffs = sql.getStaff(role);

                if (staffs == null) return;

                foreach (Staff staff in staffs)
                {
                    listBox26.Items.Add(staff.id!);
                    listBox25.Items.Add(staff.name);
                    listBox24.Items.Add(staff.gender.ToString());
                    listBox23.Items.Add(staff.address);
                    listBox22.Items.Add(staff.phoneNo.ToString());
                    listBox19.Items.Add(staff.email);
                    listBox21.Items.Add(staff.salary.ToString());
                    listBox20.Items.Add(staff.department.ToString());
                    listBox18.Items.Add(staff.role.ToString());

                }
            }
            catch (Exception ex)
            {
                //am not making any label for errors here since it will be fully under control
            }
        }
    }
}
