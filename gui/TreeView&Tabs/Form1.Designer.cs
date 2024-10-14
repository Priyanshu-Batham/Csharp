namespace TreeView_Tabs
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
            TreeNode treeNode1 = new TreeNode("OLED");
            TreeNode treeNode2 = new TreeNode("AMOLED");
            TreeNode treeNode3 = new TreeNode("LED", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Emissive", new TreeNode[] { treeNode3 });
            TreeNode treeNode5 = new TreeNode("LCD");
            TreeNode treeNode6 = new TreeNode("Non-Emissive", new TreeNode[] { treeNode5 });
            TreeNode treeNode7 = new TreeNode("Flat Panel Displays", new TreeNode[] { treeNode4, treeNode6 });
            treeView1 = new TreeView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Left;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node5";
            treeNode1.Text = "OLED";
            treeNode2.Name = "Node6";
            treeNode2.Text = "AMOLED";
            treeNode3.Name = "Node3";
            treeNode3.Text = "LED";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Emissive";
            treeNode5.Name = "Node4";
            treeNode5.Text = "LCD";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Non-Emissive";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Flat Panel Displays";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode7 });
            treeView1.Size = new Size(149, 450);
            treeView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(149, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(651, 450);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(643, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 33);
            label1.Name = "label1";
            label1.Size = new Size(316, 86);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(643, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Code";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(treeView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
    }
}
