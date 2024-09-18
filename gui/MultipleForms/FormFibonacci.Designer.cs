namespace MultipleForms
{
    partial class FormFibonacci
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
            lblFibonacciOutput = new Label();
            btnFibonacciSubmit = new Button();
            txtFibonacci = new TextBox();
            lblFibonacci = new Label();
            SuspendLayout();
            // 
            // lblFibonacciOutput
            // 
            lblFibonacciOutput.AutoSize = true;
            lblFibonacciOutput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFibonacciOutput.Location = new Point(384, 294);
            lblFibonacciOutput.Name = "lblFibonacciOutput";
            lblFibonacciOutput.Size = new Size(0, 32);
            lblFibonacciOutput.TabIndex = 7;
            // 
            // btnFibonacciSubmit
            // 
            btnFibonacciSubmit.Location = new Point(318, 223);
            btnFibonacciSubmit.Name = "btnFibonacciSubmit";
            btnFibonacciSubmit.Size = new Size(171, 39);
            btnFibonacciSubmit.TabIndex = 6;
            btnFibonacciSubmit.Text = "Enter";
            btnFibonacciSubmit.UseVisualStyleBackColor = true;
            btnFibonacciSubmit.Click += btnFibonacciSubmit_Click;
            // 
            // txtFibonacci
            // 
            txtFibonacci.Location = new Point(262, 183);
            txtFibonacci.Name = "txtFibonacci";
            txtFibonacci.Size = new Size(276, 23);
            txtFibonacci.TabIndex = 5;
            // 
            // lblFibonacci
            // 
            lblFibonacci.AutoSize = true;
            lblFibonacci.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFibonacci.Location = new Point(275, 123);
            lblFibonacci.Name = "lblFibonacci";
            lblFibonacci.Size = new Size(263, 32);
            lblFibonacci.TabIndex = 4;
            lblFibonacci.Text = "Fibonacci elt at nth pos";
            // 
            // FormFibonacci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFibonacciOutput);
            Controls.Add(btnFibonacciSubmit);
            Controls.Add(txtFibonacci);
            Controls.Add(lblFibonacci);
            Name = "FormFibonacci";
            Text = "FormFibonacci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFibonacciOutput;
        private Button btnFibonacciSubmit;
        private TextBox txtFibonacci;
        private Label lblFibonacci;
    }
}