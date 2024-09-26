namespace Traffic_Car
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 50);
            label1.MinimumSize = new Size(100, 50);
            label1.Name = "label1";
            label1.Size = new Size(100, 50);
            label1.TabIndex = 0;
            label1.Text = "Red";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(321, 113);
            label2.MinimumSize = new Size(100, 50);
            label2.Name = "label2";
            label2.Size = new Size(100, 50);
            label2.TabIndex = 1;
            label2.Text = "Yellow";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(321, 176);
            label3.MinimumSize = new Size(100, 50);
            label3.Name = "label3";
            label3.Size = new Size(100, 50);
            label3.TabIndex = 2;
            label3.Text = "Green";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.UseMnemonic = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(381, 321);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 5, 10, 5);
            label4.Size = new Size(47, 25);
            label4.TabIndex = 3;
            label4.Text = "Car";
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private System.Windows.Forms.Timer timer2;
    }
}
