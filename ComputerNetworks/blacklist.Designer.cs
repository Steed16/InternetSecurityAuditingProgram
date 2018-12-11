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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Social media");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Gaming");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("NSFW");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Other");
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
            this.RandomFactText = new System.Windows.Forms.Label();
            this.RandomFactLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 115);
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
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hello human! How would you like to make the \r\ninternet less fun today???";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // blacklistSiteTextBox
            // 
            this.blacklistSiteTextBox.BackColor = System.Drawing.Color.Fuchsia;
            this.blacklistSiteTextBox.Location = new System.Drawing.Point(40, 211);
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
            this.label3.Location = new System.Drawing.Point(35, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "View blacklisted websites here:";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Fuchsia;
            this.treeView1.Location = new System.Drawing.Point(214, 310);
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
            this.treeView1.Size = new System.Drawing.Size(183, 122);
            this.treeView1.TabIndex = 8;
            // 
            // blacklistButton
            // 
            this.blacklistButton.BackColor = System.Drawing.Color.Fuchsia;
            this.blacklistButton.Location = new System.Drawing.Point(466, 184);
            this.blacklistButton.Margin = new System.Windows.Forms.Padding(2);
            this.blacklistButton.Name = "blacklistButton";
            this.blacklistButton.Size = new System.Drawing.Size(83, 33);
            this.blacklistButton.TabIndex = 10;
            this.blacklistButton.Text = "Submit";
            this.blacklistButton.UseVisualStyleBackColor = false;
            this.blacklistButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tagNameInput
            // 
            this.tagNameInput.BackColor = System.Drawing.Color.Fuchsia;
            this.tagNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagNameInput.Location = new System.Drawing.Point(40, 158);
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
            this.socialMediaRadio.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.socialMediaRadio.Location = new System.Drawing.Point(263, 159);
            this.socialMediaRadio.Name = "socialMediaRadio";
            this.socialMediaRadio.Size = new System.Drawing.Size(86, 17);
            this.socialMediaRadio.TabIndex = 12;
            this.socialMediaRadio.TabStop = true;
            this.socialMediaRadio.Text = "Social Media";
            this.socialMediaRadio.UseVisualStyleBackColor = false;
            this.socialMediaRadio.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // gamingRadio
            // 
            this.gamingRadio.AutoSize = true;
            this.gamingRadio.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.gamingRadio.Location = new System.Drawing.Point(263, 182);
            this.gamingRadio.Name = "gamingRadio";
            this.gamingRadio.Size = new System.Drawing.Size(61, 17);
            this.gamingRadio.TabIndex = 13;
            this.gamingRadio.TabStop = true;
            this.gamingRadio.Text = "Gaming";
            this.gamingRadio.UseVisualStyleBackColor = false;
            this.gamingRadio.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // nsfwRadio
            // 
            this.nsfwRadio.AutoSize = true;
            this.nsfwRadio.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.nsfwRadio.Location = new System.Drawing.Point(263, 206);
            this.nsfwRadio.Name = "nsfwRadio";
            this.nsfwRadio.Size = new System.Drawing.Size(57, 17);
            this.nsfwRadio.TabIndex = 14;
            this.nsfwRadio.TabStop = true;
            this.nsfwRadio.Text = "NSFW";
            this.nsfwRadio.UseVisualStyleBackColor = false;
            this.nsfwRadio.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // otherRadio
            // 
            this.otherRadio.AutoSize = true;
            this.otherRadio.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.otherRadio.Location = new System.Drawing.Point(263, 228);
            this.otherRadio.Name = "otherRadio";
            this.otherRadio.Size = new System.Drawing.Size(51, 17);
            this.otherRadio.TabIndex = 15;
            this.otherRadio.TabStop = true;
            this.otherRadio.Text = "Other";
            this.otherRadio.UseVisualStyleBackColor = false;
            this.otherRadio.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // selectedCategory
            // 
            this.selectedCategory.BackColor = System.Drawing.Color.Fuchsia;
            this.selectedCategory.Location = new System.Drawing.Point(263, 250);
            this.selectedCategory.Name = "selectedCategory";
            this.selectedCategory.ReadOnly = true;
            this.selectedCategory.Size = new System.Drawing.Size(100, 20);
            this.selectedCategory.TabIndex = 16;
            this.selectedCategory.Text = "Other";
            this.selectedCategory.Visible = false;
            // 
            // RandomFactText
            // 
            this.RandomFactText.AutoEllipsis = true;
            this.RandomFactText.AutoSize = true;
            this.RandomFactText.Location = new System.Drawing.Point(37, 470);
            this.RandomFactText.Name = "RandomFactText";
            this.RandomFactText.Size = new System.Drawing.Size(369, 13);
            this.RandomFactText.TabIndex = 17;
            this.RandomFactText.Text = "RandomFactWillBeGeneratedHereAndHopefullyThisIsALongEnoughTextBox";
            this.RandomFactText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RandomFactLabel
            // 
            this.RandomFactLabel.AutoSize = true;
            this.RandomFactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomFactLabel.Location = new System.Drawing.Point(37, 444);
            this.RandomFactLabel.Name = "RandomFactLabel";
            this.RandomFactLabel.Size = new System.Drawing.Size(208, 16);
            this.RandomFactLabel.TabIndex = 18;
            this.RandomFactLabel.Text = "And here\'s a random fun fact:";
            // 
            // blacklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(600, 501);
            this.Controls.Add(this.RandomFactLabel);
            this.Controls.Add(this.RandomFactText);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label RandomFactText;
        private System.Windows.Forms.Label RandomFactLabel;
    }
}