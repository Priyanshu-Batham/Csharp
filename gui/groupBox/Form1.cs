using groupBox;

namespace groupBox
{
    public partial class Form1 : Form
    {
        List<Ques> englishQues;
        List<Ques> competitiveProgrammingQues;
        List<Ques> linuxQues;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //filling age number in combobox
            for (int i = 0; i < 25; i++)
            {
                comboBox2.Items.Add(i+1);
            }

            //filling questions
            englishQues = new List<Ques>();
            competitiveProgrammingQues = new List<Ques>();
            linuxQues = new List<Ques>();

            englishQues.Add(new Ques("What is the opposite of word 'Poor'?", ["Rich", "Greedy", "Ambani", "Begger"], 2));
            competitiveProgrammingQues.Add(new Ques("What is the time complexity of QuickSort?", ["nlogn", "n**2", "Linear", "constant"], 0));
            competitiveProgrammingQues.Add(new Ques("Which of the following is a string matching algorithm", ["Sieve of Erastosthenes", "Kosaraju's algo", "Floyd's Tortoise and Hare", "Knuth-Morris-Pratt"], 3));
            linuxQues.Add(new Ques("What happens if you run 'sudo rm -rf /'?", ["nothing", "rest in peace", "boost performance", "updates sys"], 1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBox1.Text;
                int age = Convert.ToInt32(comboBox2.Text);
                String subject = comboBox1.Text;

                QuizGame formQuizGame;

                if (name != "" && age != null && subject != null)
                {
                    if (subject == "English")
                    {
                        formQuizGame = new QuizGame(englishQues);
                    }
                    else if (subject == "Competitive Programming")
                    {
                        formQuizGame = new QuizGame(competitiveProgrammingQues);
                    }
                    else
                    {
                        formQuizGame = new QuizGame(linuxQues);
                    }

                    formQuizGame.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                label4.Text = "Fill All Details Properly";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int age;
            try
            {
                age = Convert.ToInt16(comboBox2.Text);
            }
            catch (Exception ex)
            {
                return;
            }

            if (age < 1 || age > 25) return;
            if (age < 11)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("English");
            }
            else if (age < 21)
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Competitive Programming");
            }
            else
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Linux");
            }
        }
    }

    //utility class for handling ques
    public class Ques
    {
        public String qusText;
        public String[] options;
        public int ansIndex;

        public Ques(String qusText, String[] options, int ansIndex)
        {
            this.qusText = qusText;
            this.options = options;
            this.ansIndex = ansIndex;
        }
    }
}
