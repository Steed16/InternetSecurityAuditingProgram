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
            this.blacklistSiteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.blacklistButton = new System.Windows.Forms.Button();
            this.tagNameInput = new System.Windows.Forms.TextBox();
            this.socialMediaRadio = new System.Windows.Forms.RadioButton();
            this.gamingRadio = new System.Windows.Forms.RadioButton();
            this.nsfwRadio = new System.Windows.Forms.RadioButton();
            this.otherRadio = new System.Windows.Forms.RadioButton();
            this.selectedCategory = new System.Windows.Forms.TextBox();
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
            // blacklistSiteTextBox
            // 
            this.blacklistSiteTextBox.Location = new System.Drawing.Point(38, 260);
            this.blacklistSiteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.blacklistSiteTextBox.Multiline = true;
            this.blacklistSiteTextBox.Name = "blacklistSiteTextBox";
            this.blacklistSiteTextBox.Size = new System.Drawing.Size(209, 33);
            this.blacklistSiteTextBox.TabIndex = 6;
            this.blacklistSiteTextBox.Text = "Enter URL Here";
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
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
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
            this.treeView1.Size = new System.Drawing.Size(183, 122);
            this.treeView1.TabIndex = 8;
            // 
            // blacklistButton
            // 
            this.blacklistButton.Location = new System.Drawing.Point(464, 233);
            this.blacklistButton.Margin = new System.Windows.Forms.Padding(2);
            this.blacklistButton.Name = "blacklistButton";
            this.blacklistButton.Size = new System.Drawing.Size(83, 33);
            this.blacklistButton.TabIndex = 10;
            this.blacklistButton.Text = "Submit";
            this.blacklistButton.UseVisualStyleBackColor = true;
            this.blacklistButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tagNameInput
            // 
            this.tagNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagNameInput.Location = new System.Drawing.Point(38, 207);
            this.tagNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.tagNameInput.MaximumSize = new System.Drawing.Size(209, 40);
            this.tagNameInput.MinimumSize = new System.Drawing.Size(209, 40);
            this.tagNameInput.Name = "tagNameInput";
            this.tagNameInput.Size = new System.Drawing.Size(209, 19);
            this.tagNameInput.TabIndex = 11;
            this.tagNameInput.Text = "Enter TagName Here";
            // 
            // socialMediaRadio
            // 
            this.socialMediaRadio.AutoSize = true;
            this.socialMediaRadio.Location = new System.Drawing.Point(261, 208);
            this.socialMediaRadio.Name = "socialMediaRadio";
            this.socialMediaRadio.Size = new System.Drawing.Size(86, 17);
            this.socialMediaRadio.TabIndex = 12;
            this.socialMediaRadio.TabStop = true;
            this.socialMediaRadio.Text = "Social Media";
            this.socialMediaRadio.UseVisualStyleBackColor = true;
            this.socialMediaRadio.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // gamingRadio
            // 
            this.gamingRadio.AutoSize = true;
            this.gamingRadio.Location = new System.Drawing.Point(261, 231);
            this.gamingRadio.Name = "gamingRadio";
            this.gamingRadio.Size = new System.Drawing.Size(61, 17);
            this.gamingRadio.TabIndex = 13;
            this.gamingRadio.TabStop = true;
            this.gamingRadio.Text = "Gaming";
            this.gamingRadio.UseVisualStyleBackColor = true;
            this.gamingRadio.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // nsfwRadio
            // 
            this.nsfwRadio.AutoSize = true;
            this.nsfwRadio.Location = new System.Drawing.Point(261, 254);
            this.nsfwRadio.Name = "nsfwRadio";
            this.nsfwRadio.Size = new System.Drawing.Size(57, 17);
            this.nsfwRadio.TabIndex = 14;
            this.nsfwRadio.TabStop = true;
            this.nsfwRadio.Text = "NSFW";
            this.nsfwRadio.UseVisualStyleBackColor = true;
            this.nsfwRadio.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // otherRadio
            // 
            this.otherRadio.AutoSize = true;
            this.otherRadio.Location = new System.Drawing.Point(261, 277);
            this.otherRadio.Name = "otherRadio";
            this.otherRadio.Size = new System.Drawing.Size(51, 17);
            this.otherRadio.TabIndex = 15;
            this.otherRadio.TabStop = true;
            this.otherRadio.Text = "Other";
            this.otherRadio.UseVisualStyleBackColor = true;
            this.otherRadio.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // selectedCategory
            // 
            this.selectedCategory.Location = new System.Drawing.Point(261, 299);
            this.selectedCategory.Name = "selectedCategory";
            this.selectedCategory.ReadOnly = true;
            this.selectedCategory.Size = new System.Drawing.Size(100, 20);
            this.selectedCategory.TabIndex = 16;
            this.selectedCategory.Text = "Other";
            this.selectedCategory.Visible = false;
            // 
            // blacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 501);
            this.Controls.Add(this.selectedCategory);
            this.Controls.Add(this.otherRadio);
            this.Controls.Add(this.nsfwRadio);
            this.Controls.Add(this.gamingRadio);
            this.Controls.Add(this.socialMediaRadio);
            this.Controls.Add(this.tagNameInput);
            this.Controls.Add(this.blacklistButton);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blacklistSiteTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "blacklist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blacklist";
            this.Load += new System.EventHandler(this.Blacklist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox blacklistSiteTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button blacklistButton;
        private System.Windows.Forms.TextBox tagNameInput;
        private System.Windows.Forms.RadioButton socialMediaRadio;
        private System.Windows.Forms.RadioButton gamingRadio;
        private System.Windows.Forms.RadioButton nsfwRadio;
        private System.Windows.Forms.RadioButton otherRadio;
        private System.Windows.Forms.TextBox selectedCategory;
    }
}