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
    public partial class FormPrime : Form
    {
        public FormPrime()
        {
            InitializeComponent();
        }

        private void btnPrimeSubmit_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtPrime.Text);
            lblPrimeOutput.Text = isPrime(num).ToString();
        }

        //custom function
        bool isPrime(int num)
        {
            if (num <= 2) return true;

            for (int i = 2; i * i < num + 1; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res = "";
            int start = Convert.ToInt32(txtStartRange.Text);
            int end = Convert.ToInt32(txtEndRange.Text);

            for (int i = start; i <= end; i++)
            {
                if (isPrime(i))
                {
                    res += i.ToString();
                    res += ", ";
                }
            }

            txtPrimeRangeOutput.Text = res;
        }
    }
}
