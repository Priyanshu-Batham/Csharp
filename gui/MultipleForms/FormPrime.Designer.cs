namespace MultipleForms
{
    partial class FormPrime
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
            lblPrimeOutput = new Label();
            btnPrimeSubmit = new Button();
            txtPrime = new TextBox();
            lblPrime = new Label();
            label1 = new Label();
            txtStartRange = new TextBox();
            txtEndRange = new TextBox();
            label2 = new Label();
            button1 = new Button();
            txtPrimeRangeOutput = new TextBox();
            SuspendLayout();
            // 
            // lblPrimeOutput
            // 
            lblPrimeOutput.AutoSize = true;
            lblPrimeOutput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrimeOutput.Location = new Point(185, 283);
            lblPrimeOutput.Name = "lblPrimeOutput";
            lblPrimeOutput.Size = new Size(0, 32);
            lblPrimeOutput.TabIndex = 7;
            // 
            // btnPrimeSubmit
            // 
            btnPrimeSubmit.Location = new Point(119, 212);
            btnPrimeSubmit.Name = "btnPrimeSubmit";
            btnPrimeSubmit.Size = new Size(171, 39);
            btnPrimeSubmit.TabIndex = 6;
            btnPrimeSubmit.Text = "Enter";
            btnPrimeSubmit.UseVisualStyleBackColor = true;
            btnPrimeSubmit.Click += btnPrimeSubmit_Click;
            // 
            // txtPrime
            // 
            txtPrime.Location = new Point(63, 172);
            txtPrime.Name = "txtPrime";
            txtPrime.Size = new Size(276, 23);
            txtPrime.TabIndex = 5;
            // 
            // lblPrime
            // 
            lblPrime.AutoSize = true;
            lblPrime.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrime.Location = new Point(154, 121);
            lblPrime.Name = "lblPrime";
            lblPrime.Size = new Size(98, 32);
            lblPrime.TabIndex = 4;
            lblPrime.Text = "Is Prime";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(526, 121);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 8;
            label1.Text = "Primes in Range";
            // 
            // txtStartRange
            // 
            txtStartRange.Location = new Point(498, 172);
            txtStartRange.Name = "txtStartRange";
            txtStartRange.Size = new Size(95, 23);
            txtStartRange.TabIndex = 9;
            // 
            // txtEndRange
            // 
            txtEndRange.Location = new Point(637, 172);
            txtEndRange.Name = "txtEndRange";
            txtEndRange.Size = new Size(95, 23);
            txtEndRange.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(608, 175);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 11;
            label2.Text = "-";
            // 
            // button1
            // 
            button1.Location = new Point(526, 212);
            button1.Name = "button1";
            button1.Size = new Size(171, 39);
            button1.TabIndex = 12;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPrimeRangeOutput
            // 
            txtPrimeRangeOutput.Location = new Point(474, 267);
            txtPrimeRangeOutput.Multiline = true;
            txtPrimeRangeOutput.Name = "txtPrimeRangeOutput";
            txtPrimeRangeOutput.ReadOnly = true;
            txtPrimeRangeOutput.ScrollBars = ScrollBars.Both;
            txtPrimeRangeOutput.Size = new Size(276, 77);
            txtPrimeRangeOutput.TabIndex = 13;
            // 
            // FormPrime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrimeRangeOutput);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtEndRange);
            Controls.Add(txtStartRange);
            Controls.Add(label1);
            Controls.Add(lblPrimeOutput);
            Controls.Add(btnPrimeSubmit);
            Controls.Add(txtPrime);
            Controls.Add(lblPrime);
            Name = "FormPrime";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrimeOutput;
        private Button btnPrimeSubmit;
        private TextBox txtPrime;
        private Label lblPrime;
        private Label label1;
        private TextBox txtStartRange;
        private TextBox txtEndRange;
        private Label label2;
        private Button button1;
        private TextBox txtPrimeRangeOutput;
    }
}