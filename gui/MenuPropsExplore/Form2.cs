using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using c = System.Console;

namespace MenuPropsExplore
{
    public partial class Form2 : Form
    {
        private int i = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            timer3.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 1000)
            {
                label1.Visible = false;
            }
            timer2.Enabled = true;
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Interval == 1000)
            {
                label1.Visible = true;
            }
            timer1.Enabled = true;
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Text = i.ToString();
            i++;
        }
    }
}
