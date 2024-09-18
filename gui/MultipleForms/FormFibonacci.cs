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
    public partial class FormFibonacci : Form
    {
        public FormFibonacci()
        {
            InitializeComponent();
        }

        private void btnFibonacciSubmit_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtFibonacci.Text);
            int res = fibonacci(num);
            lblFibonacciOutput.Text = res.ToString();
        }

        //custom function
        int fibonacci(int num)
        {
            //base case
            if(num == 0 || num == 1)
            {
                return num;
            }

            //recursion
            return fibonacci(num - 1) + fibonacci(num - 2);
        }
    }
}
