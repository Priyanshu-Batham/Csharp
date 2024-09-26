using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicControls
{
    public partial class MathsOperationForm : Form
    {
        //class properties
        string operation = MathSelectForm.operation;
        TextBox txt1;
        TextBox txt2;
        TextBox txt3;
        TextBox txt4;
        public MathsOperationForm()
        {
            InitializeComponent();
        }

        private void MathsFn_Load(object sender, EventArgs e)
        {
            //Initializing controls dynamically
            button1.Text = operation;
            lblMain.Text = operation;


            if (operation == "Min")
            {
                txt1 = new TextBox();
                txt1.Location = new Point(340, 100);
                txt2 = new TextBox();
                txt2.Location = new Point(340, 130);
                txt3 = new TextBox();
                txt3.Location = new Point(340, 160);
                txt4 = new TextBox();
                txt4.Location = new Point(340, 190);

                this.Controls.Add(txt1);
                this.Controls.Add(txt2);
                this.Controls.Add(txt3);
                this.Controls.Add(txt4);
            }
            else if (operation == "Max")
            {
                txt1 = new TextBox();
                txt1.Location = new Point(340, 100);
                txt2 = new TextBox();
                txt2.Location = new Point(340, 130);
                txt3 = new TextBox();
                txt3.Location = new Point(340, 160);
                txt4 = new TextBox();
                txt4.Location = new Point(340, 190);

                this.Controls.Add(txt1);
                this.Controls.Add(txt2);
                this.Controls.Add(txt3);
                this.Controls.Add(txt4);
            }
            else if (operation == "Square")
            {
                txt1 = new TextBox();
                txt1.Location = new Point(340, 100);

                this.Controls.Add(txt1);
            }
            else if (operation == "Power")
            {
                txt1 = new TextBox();
                txt1.Location = new Point(340, 100);
                txt2 = new TextBox();
                txt2.Location = new Point(340, 130);

                this.Controls.Add(txt1);
                this.Controls.Add(txt2);
            }
            else if (operation == "Absolute")
            {
                txt1 = new TextBox();
                txt1.Location = new Point(340, 100);

                this.Controls.Add(txt1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operation == "Min")
            {
                int inp1 = Convert.ToInt32(txt1.Text);
                int inp2 = Convert.ToInt32(txt2.Text);
                int inp3 = Convert.ToInt32(txt3.Text);
                int inp4 = Convert.ToInt32(txt4.Text);

                int mini = Math.Min(inp1, inp2);
                mini = Math.Min(mini, inp3);
                mini = Math.Min(mini, inp4);

                lblOutput.Text = mini.ToString();
            }
            else if (operation == "Max")
            {
                int inp1 = Convert.ToInt32(txt1.Text);
                int inp2 = Convert.ToInt32(txt2.Text);
                int inp3 = Convert.ToInt32(txt3.Text);
                int inp4 = Convert.ToInt32(txt4.Text);

                int maxi = Math.Max(inp1, inp2);
                maxi = Math.Max(maxi, inp3);
                maxi = Math.Max(maxi, inp4);

                lblOutput.Text = maxi.ToString();
            }
            else if (operation == "Square")
            {
                int inp1 = Convert.ToInt32(txt1.Text);

                lblOutput.Text = (inp1 * inp1).ToString();
            }
            else if (operation == "Power")
            {
                int inp1 = Convert.ToInt32(txt1.Text);
                int inp2 = Convert.ToInt32(txt2.Text);

                lblOutput.Text = Math.Pow(inp1, inp2).ToString();
            }
            else if (operation == "Absolute")
            {
                int inp1 = Convert.ToInt32(txt1.Text);
                lblOutput.Text = Math.Abs(inp1).ToString();
            }
        }
    }
}
