namespace MultipleForms
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
            lblWelcome = new Label();
            btnFactorial = new Button();
            btnPrime = new Button();
            btnFibonacci = new Button();
            btnValidEmail = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(299, 98);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(214, 32);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome To Utility";
            // 
            // btnFactorial
            // 
            btnFactorial.Location = new Point(314, 158);
            btnFactorial.Name = "btnFactorial";
            btnFactorial.Size = new Size(173, 51);
            btnFactorial.TabIndex = 1;
            btnFactorial.Text = "Factorial";
            btnFactorial.UseVisualStyleBackColor = true;
            btnFactorial.Click += btnFactorial_Click;
            // 
            // btnPrime
            // 
            btnPrime.Location = new Point(314, 215);
            btnPrime.Name = "btnPrime";
            btnPrime.Size = new Size(173, 51);
            btnPrime.TabIndex = 2;
            btnPrime.Text = "Prime";
            btnPrime.UseVisualStyleBackColor = true;
            btnPrime.Click += btnPrime_Click;
            // 
            // btnFibonacci
            // 
            btnFibonacci.Location = new Point(314, 272);
            btnFibonacci.Name = "btnFibonacci";
            btnFibonacci.Size = new Size(173, 51);
            btnFibonacci.TabIndex = 3;
            btnFibonacci.Text = "Fibonacci";
            btnFibonacci.UseVisualStyleBackColor = true;
            btnFibonacci.Click += btnFibonacci_Click;
            // 
            // btnValidEmail
            // 
            btnValidEmail.Location = new Point(314, 329);
            btnValidEmail.Name = "btnValidEmail";
            btnValidEmail.Size = new Size(173, 51);
            btnValidEmail.TabIndex = 4;
            btnValidEmail.Text = "Is Valid Email";
            btnValidEmail.UseVisualStyleBackColor = true;
            btnValidEmail.Click += btnValidEmail_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValidEmail);
            Controls.Add(btnFibonacci);
            Controls.Add(btnPrime);
            Controls.Add(btnFactorial);
            Controls.Add(lblWelcome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnFactorial;
        private Button btnPrime;
        private Button btnFibonacci;
        private Button btnValidEmail;
    }
}
