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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Social media");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Gaming");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("NSFW");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Other");
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.blacklistTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.catagoryCheckList = new System.Windows.Forms.CheckedListBox();
            this.blacklistButton = new System.Windows.Forms.Button();
            this.tagNameInput = new System.Windows.Forms.TextBox();
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
            this.blacklistTextBox.Location = new System.Drawing.Point(50, 320);
            this.blacklistTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blacklistTextBox.Multiline = true;
            this.blacklistTextBox.Name = "blacklistTextBox";
            this.blacklistTextBox.Size = new System.Drawing.Size(277, 40);
            this.blacklistTextBox.TabIndex = 6;
            this.blacklistTextBox.Text = "Enter URL Here";
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
            this.treeView1.Location = new System.Drawing.Point(283, 441);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            treeNode5.Name = "Social media";
            treeNode5.Tag = "parent";
            treeNode5.Text = "Social media";
            treeNode6.Name = "Gaming";
            treeNode6.Tag = "parent";
            treeNode6.Text = "Gaming";
            treeNode7.Name = "NSFW";
            treeNode7.Tag = "parent";
            treeNode7.Text = "NSFW";
            treeNode8.Name = "Other";
            treeNode8.Tag = "parent";
            treeNode8.Text = "Other";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(243, 149);
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
            this.catagoryCheckList.Location = new System.Drawing.Point(333, 255);
            this.catagoryCheckList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.catagoryCheckList.Name = "catagoryCheckList";
            this.catagoryCheckList.Size = new System.Drawing.Size(228, 106);
            this.catagoryCheckList.TabIndex = 9;
            // 
            // blacklistButton
            // 
            this.blacklistButton.Location = new System.Drawing.Point(618, 287);
            this.blacklistButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blacklistButton.Name = "blacklistButton";
            this.blacklistButton.Size = new System.Drawing.Size(111, 41);
            this.blacklistButton.TabIndex = 10;
            this.blacklistButton.Text = "Submit";
            this.blacklistButton.UseVisualStyleBackColor = true;
            this.blacklistButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tagNameInput
            // 
            this.tagNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagNameInput.Location = new System.Drawing.Point(50, 255);
            this.tagNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tagNameInput.MaximumSize = new System.Drawing.Size(277, 40);
            this.tagNameInput.MinimumSize = new System.Drawing.Size(277, 40);
            this.tagNameInput.Name = "tagNameInput";
            this.tagNameInput.Size = new System.Drawing.Size(277, 40);
            this.tagNameInput.TabIndex = 11;
            this.tagNameInput.Text = "Enter TagName Here";
            // 
            // blacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.tagNameInput);
            this.Controls.Add(this.blacklistButton);
            this.Controls.Add(this.catagoryCheckList);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blacklistTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "blacklist";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.blacklist_Load);
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
        private System.Windows.Forms.TextBox tagNameInput;
    }
}