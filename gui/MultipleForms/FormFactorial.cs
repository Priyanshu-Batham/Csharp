using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class FormFactorial : Form
    {
        public FormFactorial()
        {
            InitializeComponent();
        }

        private void FormFactorial_Load(object sender, EventArgs e)
        {

        }

        private void btnFactorialSubmit_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtFactorial.Text);
            int res = factorialOfNum(num);
            lblFactorialOutput.Text = res.ToString();
        }

        //custom functions
        int factorialOfNum(int num)
        {
            //base case of recursion
            if (num == 1) return 1;

            //recursion
            return num * factorialOfNum(num - 1);
        }
    }
}
