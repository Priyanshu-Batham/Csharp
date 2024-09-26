namespace DynamicControls
{
    partial class MathsForm
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
            lblOutput = new Label();
            lblMain = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(346, 309);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Process";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(346, 347);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 30);
            lblOutput.TabIndex = 1;
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMain.Location = new Point(359, 57);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(0, 30);
            lblMain.TabIndex = 2;
            // 
            // MathsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMain);
            Controls.Add(lblOutput);
            Controls.Add(button1);
            Name = "MathsForm";
            Text = "MathsFn";
            Load += MathsFn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblOutput;
        private Label lblMain;
    }
}