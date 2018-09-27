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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("facebook.com");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("twitter.com");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Social Media", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("ninjakiwi.com");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("coolmathgames.com");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Gaming", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
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
            this.treeView1.Location = new System.Drawing.Point(261, 248);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "Node1";
            treeNode7.Text = "facebook.com";
            treeNode8.Name = "Node2";
            treeNode8.Text = "twitter.com";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Social Media";
            treeNode10.Name = "Node4";
            treeNode10.Text = "ninjakiwi.com";
            treeNode11.Name = "Node6";
            treeNode11.Text = "coolmathgames.com";
            treeNode12.Name = "Node3";
            treeNode12.Text = "Gaming";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(243, 149);
            this.treeView1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
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