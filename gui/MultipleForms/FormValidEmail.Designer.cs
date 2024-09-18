namespace MultipleForms
{
    partial class FormValidEmail
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
            lbl = new Label();
            txtEmail = new TextBox();
            btnEmailSubmit = new Button();
            lblEmailOutput = new Label();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Viner Hand ITC", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl.Location = new Point(293, 103);
            lbl.Name = "lbl";
            lbl.Size = new Size(231, 39);
            lbl.TabIndex = 0;
            lbl.Text = "Enter Your Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(293, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(231, 23);
            txtEmail.TabIndex = 1;
            // 
            // btnEmailSubmit
            // 
            btnEmailSubmit.Location = new Point(366, 204);
            btnEmailSubmit.Name = "btnEmailSubmit";
            btnEmailSubmit.Size = new Size(75, 23);
            btnEmailSubmit.TabIndex = 2;
            btnEmailSubmit.Text = "Enter";
            btnEmailSubmit.UseVisualStyleBackColor = true;
            btnEmailSubmit.Click += btnEmailSubmit_Click;
            // 
            // lblEmailOutput
            // 
            lblEmailOutput.AutoSize = true;
            lblEmailOutput.Font = new Font("Viner Hand ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailOutput.Location = new Point(358, 248);
            lblEmailOutput.Name = "lblEmailOutput";
            lblEmailOutput.Size = new Size(86, 39);
            lblEmailOutput.TabIndex = 3;
            lblEmailOutput.Text = "label1";
            // 
            // FormValidEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEmailOutput);
            Controls.Add(btnEmailSubmit);
            Controls.Add(txtEmail);
            Controls.Add(lbl);
            Name = "FormValidEmail";
            Text = "FormValidEmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private TextBox txtEmail;
        private Button btnEmailSubmit;
        private Label lblEmailOutput;
    }
}