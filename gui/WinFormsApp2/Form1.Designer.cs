namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblUserpassword = new Label();
            txtUsername = new TextBox();
            txtUserpassword = new TextBox();
            lblError = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAddUser = new Button();
            btnLogin = new Button();
            lblAddUser = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(451, 103);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(90, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Enter Username";
            // 
            // lblUserpassword
            // 
            lblUserpassword.AutoSize = true;
            lblUserpassword.Location = new Point(451, 140);
            lblUserpassword.Name = "lblUserpassword";
            lblUserpassword.Size = new Size(87, 15);
            lblUserpassword.TabIndex = 1;
            lblUserpassword.Text = "Enter Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(547, 103);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(155, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtUserpassword
            // 
            txtUserpassword.Location = new Point(547, 140);
            txtUserpassword.Name = "txtUserpassword";
            txtUserpassword.PasswordChar = '*';
            txtUserpassword.Size = new Size(155, 23);
            txtUserpassword.TabIndex = 3;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.Location = new Point(575, 247);
            lblError.Name = "lblError";
            lblError.Size = new Size(63, 25);
            lblError.TabIndex = 5;
            lblError.Text = "label3";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 96);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 8;
            label1.Text = "Enter Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 140);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 9;
            label2.Text = "Enter Password";
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(167, 193);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(75, 23);
            btnAddUser.TabIndex = 10;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += button1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(556, 181);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 27);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblAddUser
            // 
            lblAddUser.AutoSize = true;
            lblAddUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddUser.Location = new Point(174, 247);
            lblAddUser.Name = "lblAddUser";
            lblAddUser.Size = new Size(105, 25);
            lblAddUser.TabIndex = 12;
            lblAddUser.Text = "lblAddUser";
            // 
            // button1
            // 
            button1.Location = new Point(353, 366);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Next Page";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblAddUser);
            Controls.Add(btnLogin);
            Controls.Add(btnAddUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblError);
            Controls.Add(txtUserpassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUserpassword);
            Controls.Add(lblUsername);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblUserpassword;
        private TextBox txtUsername;
        private TextBox txtUserpassword;
        private Button btnCommand;
        private Label lblError;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button btnAddUser;
        private Label label4;
        private Button btnLogin;
        private Label lblAddUser;
        private Button button1;
    }
}
