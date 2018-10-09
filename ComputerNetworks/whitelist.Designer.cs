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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello human! How would you like to make the \r\ninternet more fun today???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose a website to whitelist here:";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(265, 247);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.treeView1.Size = new System.Drawing.Size(243, 149);
            this.treeView1.TabIndex = 3;
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.removeFromBlacklist);
            // 
            // whitelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "whitelist";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
    }
}