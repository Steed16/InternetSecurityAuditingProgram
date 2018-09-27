namespace ComputerNetworks
{
    partial class blacklist
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("facebook.com");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("twitter.com");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Social Media", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("ninjakiwi.com");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("coolmathgames.com");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Gaming", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.blacklistTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input a website to blacklist here:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hello human! How would you like to make the \r\ninternet less fun today???";
            // 
            // blacklistTextBox
            // 
            this.blacklistTextBox.Location = new System.Drawing.Point(118, 254);
            this.blacklistTextBox.Multiline = true;
            this.blacklistTextBox.Name = "blacklistTextBox";
            this.blacklistTextBox.Size = new System.Drawing.Size(317, 40);
            this.blacklistTextBox.TabIndex = 6;
            this.blacklistTextBox.Text = "Enter Here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "View blacklisted websites here:";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(282, 441);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "facebook.com";
            treeNode2.Name = "Node2";
            treeNode2.Text = "twitter.com";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Social Media";
            treeNode4.Name = "Node4";
            treeNode4.Text = "ninjakiwi.com";
            treeNode5.Name = "Node6";
            treeNode5.Text = "coolmathgames.com";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Gaming";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(243, 149);
            this.treeView1.TabIndex = 8;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Social media",
            "Gaming",
            "NSFW",
            "Other"});
            this.checkedListBox1.Location = new System.Drawing.Point(479, 254);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(228, 123);
            this.checkedListBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // blacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blacklistTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "blacklist";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox blacklistTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
    }
}