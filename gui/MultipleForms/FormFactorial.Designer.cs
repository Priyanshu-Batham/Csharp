namespace MultipleForms
{
    partial class FormFactorial
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
            lblFactorial = new Label();
            txtFactorial = new TextBox();
            btnFactorialSubmit = new Button();
            lblFactorialOutput = new Label();
            SuspendLayout();
            // 
            // lblFactorial
            // 
            lblFactorial.AutoSize = true;
            lblFactorial.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFactorial.Location = new Point(356, 79);
            lblFactorial.Name = "lblFactorial";
            lblFactorial.Size = new Size(102, 32);
            lblFactorial.TabIndex = 0;
            lblFactorial.Text = "Factorial";
            // 
            // txtFactorial
            // 
            txtFactorial.Location = new Point(261, 137);
            txtFactorial.Name = "txtFactorial";
            txtFactorial.Size = new Size(276, 23);
            txtFactorial.TabIndex = 1;
            // 
            // btnFactorialSubmit
            // 
            btnFactorialSubmit.Location = new Point(317, 177);
            btnFactorialSubmit.Name = "btnFactorialSubmit";
            btnFactorialSubmit.Size = new Size(171, 39);
            btnFactorialSubmit.TabIndex = 2;
            btnFactorialSubmit.Text = "Enter";
            btnFactorialSubmit.UseVisualStyleBackColor = true;
            btnFactorialSubmit.Click += btnFactorialSubmit_Click;
            // 
            // lblFactorialOutput
            // 
            lblFactorialOutput.AutoSize = true;
            lblFactorialOutput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFactorialOutput.Location = new Point(383, 248);
            lblFactorialOutput.Name = "lblFactorialOutput";
            lblFactorialOutput.Size = new Size(0, 32);
            lblFactorialOutput.TabIndex = 3;
            // 
            // FormFactorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFactorialOutput);
            Controls.Add(btnFactorialSubmit);
            Controls.Add(txtFactorial);
            Controls.Add(lblFactorial);
            Name = "FormFactorial";
            Text = "FormFactorial";
            Load += FormFactorial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFactorial;
        private TextBox txtFactorial;
        private Button btnFactorialSubmit;
        private Label lblFactorialOutput;
    }
}