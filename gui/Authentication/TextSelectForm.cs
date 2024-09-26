using DynamicControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authentication
{
    public partial class TextSelectForm : Form
    {
        public static string operation;
        private void TextSelectForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Contains Substring");
            comboBox1.Items.Add("Is Uppercase");
            comboBox1.Items.Add("Is Lowercase");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") return;
            operation = comboBox1.Text;
            
        }
    }
}
