namespace Authentication
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            listBox1 = new ListBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(244, 317);
            button1.Name = "button1";
            button1.Size = new Size(109, 33);
            button1.TabIndex = 16;
            button1.Text = "Add User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(244, 205);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 208);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 14;
            label4.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 179);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 12;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 248);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 11;
            label2.Text = "User Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 77);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 10;
            label1.Text = "Registration Page";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(232, 248);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(244, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 150);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 18;
            label5.Text = "Roll No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(273, 384);
            label6.Name = "label6";
            label6.Size = new Size(0, 32);
            label6.TabIndex = 20;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(429, 147);
            listBox1.MultiColumn = true;
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(324, 94);
            listBox1.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(545, 77);
            label7.Name = "label7";
            label7.Size = new Size(114, 32);
            label7.TabIndex = 22;
            label7.Text = "All Users";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(listBox1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "RegistrationForm";
            Text = "Registration Form";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private ListBox listBox1;
        private Label label7;
    }
}