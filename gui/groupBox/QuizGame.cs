using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groupBox
{
    public partial class QuizGame : Form
    {
        List<Ques> ques;
        int currentQuesIndex;
        int rightAns;
        int totalQues;

        //param constructor
        public QuizGame(List<Ques> ques)
        {
            InitializeComponent();
            //we got the quiz data
            this.ques = ques;
            currentQuesIndex = 0;
            rightAns = 0;
            totalQues = ques.Count;
        }

        private void QuizGame_Load(object sender, EventArgs e)
        {
            //showing the first ques with options
            labelQues.Text = ques[currentQuesIndex].qusText;
            radioButton1.Text = ques[currentQuesIndex].options[0];
            radioButton2.Text = ques[currentQuesIndex].options[1];
            radioButton3.Text = ques[currentQuesIndex].options[2];
            radioButton4.Text = ques[currentQuesIndex].options[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ansIndex = -1;
            
            //picking the selected radio button
            if(radioButton1.Checked == true) ansIndex = 0;
            if (radioButton2.Checked == true) ansIndex = 1;
            if (radioButton3.Checked == true) ansIndex = 2;
            if (radioButton4.Checked == true) ansIndex = 3;

            //if no button is selected, return
            if (ansIndex == -1) return;

            //if the ans is right
            if (ansIndex == ques[currentQuesIndex].ansIndex) rightAns++;

            //going to the next ques
            currentQuesIndex++;

            //if it was the last ques
            if(currentQuesIndex == ques.Count)
            {
                finish_game();
                return;
            }

            //showing the next ques with options
            labelQues.Text = ques[currentQuesIndex].qusText;
            radioButton1.Text = ques[currentQuesIndex].options[0];
            radioButton2.Text = ques[currentQuesIndex].options[1];
            radioButton3.Text = ques[currentQuesIndex].options[2];
            radioButton4.Text = ques[currentQuesIndex].options[3];
        }

        private void finish_game()
        {
            labelQues.Text = $"Correct Answers: {this.rightAns} | Total Answers: {this.totalQues}";
            groupBox1.Visible = false;
            button1.Visible = false;
        }
    }
}
