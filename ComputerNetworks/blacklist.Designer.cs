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
            this.catagoryCheckList = new System.Windows.Forms.CheckedListBox();
            this.blacklistButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input a website to blacklist here:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hello human! How would you like to make the \r\ninternet less fun today???";
            // 
            // blacklistTextBox
            // 
            this.blacklistTextBox.Location = new System.Drawing.Point(88, 206);
            this.blacklistTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.blacklistTextBox.Multiline = true;
            this.blacklistTextBox.Name = "blacklistTextBox";
            this.blacklistTextBox.Size = new System.Drawing.Size(239, 33);
            this.blacklistTextBox.TabIndex = 6;
            this.blacklistTextBox.Text = "Enter Here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "View blacklisted websites here:";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(212, 358);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.treeView1.Size = new System.Drawing.Size(183, 122);
            this.treeView1.TabIndex = 8;
            // 
            // catagoryCheckList
            // 
            this.catagoryCheckList.FormattingEnabled = true;
            this.catagoryCheckList.Items.AddRange(new object[] {
            "Social media",
            "Gaming",
            "NSFW",
            "Other"});
            this.catagoryCheckList.Location = new System.Drawing.Point(359, 206);
            this.catagoryCheckList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.catagoryCheckList.Name = "catagoryCheckList";
            this.catagoryCheckList.Size = new System.Drawing.Size(172, 94);
            this.catagoryCheckList.TabIndex = 9;
            // 
            // blacklistButton
            // 
            this.blacklistButton.Location = new System.Drawing.Point(228, 265);
            this.blacklistButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.blacklistButton.Name = "blacklistButton";
            this.blacklistButton.Size = new System.Drawing.Size(83, 33);
            this.blacklistButton.TabIndex = 10;
            this.blacklistButton.Text = "Submit";
            this.blacklistButton.UseVisualStyleBackColor = true;
            this.blacklistButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // blacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 501);
            this.Controls.Add(this.blacklistButton);
            this.Controls.Add(this.catagoryCheckList);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blacklistTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.CheckedListBox catagoryCheckList;
        private System.Windows.Forms.Button blacklistButton;
    }
}