namespace ComputerNetworks
{
    partial class whitelist
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Social media");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Gaming");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("NSFW");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Other");
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.RandomFacts = new System.Windows.Forms.Label();
            this.RandomFactText = new System.Windows.Forms.Label();
            this.RandomTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(562, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose a website from the menu below to whitelist:";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Cyan;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(220, 227);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Social media";
            treeNode1.Tag = "parent";
            treeNode1.Text = "Social media";
            treeNode2.Name = "Gaming";
            treeNode2.Tag = "parent";
            treeNode2.Text = "Gaming";
            treeNode3.Name = "NSFW";
            treeNode3.Tag = "parent";
            treeNode3.Text = "NSFW";
            treeNode4.Name = "Other";
            treeNode4.Tag = "parent";
            treeNode4.Text = "Other";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(166, 143);
            this.treeView1.TabIndex = 3;
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RemoveFromBlacklist);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hello Again Human!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RandomFacts
            // 
            this.RandomFacts.AutoSize = true;
            this.RandomFacts.Location = new System.Drawing.Point(166, 355);
            this.RandomFacts.Name = "RandomFacts";
            this.RandomFacts.Size = new System.Drawing.Size(0, 15);
            this.RandomFacts.TabIndex = 5;
            // 
            // RandomFactText
            // 
            this.RandomFactText.AutoSize = true;
            this.RandomFactText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomFactText.Location = new System.Drawing.Point(19, 449);
            this.RandomFactText.Name = "RandomFactText";
            this.RandomFactText.Size = new System.Drawing.Size(333, 13);
            this.RandomFactText.TabIndex = 6;
            this.RandomFactText.Text = "HopefullyTheRandomFactTextIsShortEnoughToFitInsideThisTextBox";
            // 
            // RandomTextLabel
            // 
            this.RandomTextLabel.AutoSize = true;
            this.RandomTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomTextLabel.Location = new System.Drawing.Point(19, 412);
            this.RandomTextLabel.Name = "RandomTextLabel";
            this.RandomTextLabel.Size = new System.Drawing.Size(208, 16);
            this.RandomTextLabel.TabIndex = 7;
            this.RandomTextLabel.Text = "And here\'s a random fun fact:";
            this.RandomTextLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // whitelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(594, 511);
            this.Controls.Add(this.RandomTextLabel);
            this.Controls.Add(this.RandomFactText);
            this.Controls.Add(this.RandomFacts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "whitelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whitelist";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RandomFacts;
        private System.Windows.Forms.Label RandomFactText;
        private System.Windows.Forms.Label RandomTextLabel;
    }
}