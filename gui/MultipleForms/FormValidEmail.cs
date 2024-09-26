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
    public partial class FormValidEmail : Form
    {
        public FormValidEmail()
        {
            InitializeComponent();
        }

        private void btnEmailSubmit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (email.Contains("@") && email.Contains(".com"))
            {
                
            }
        }
    }
}
