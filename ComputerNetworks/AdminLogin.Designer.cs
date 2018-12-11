namespace ComputerNetworks
{
    partial class AdminLogin
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
            this.username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.username.Location = new System.Drawing.Point(121, 132);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(119, 26);
            this.username.TabIndex = 0;
            this.username.Text = "Username:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Password.Location = new System.Drawing.Point(124, 188);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(114, 26);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password:";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Magenta;
            this.submit.Location = new System.Drawing.Point(249, 270);
            this.submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(97, 31);
            this.submit.TabIndex = 2;
            this.submit.Text = "Submit Dat Boi";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // textUsername
            // 
            this.textUsername.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.ForeColor = System.Drawing.Color.SpringGreen;
            this.textUsername.Location = new System.Drawing.Point(249, 132);
            this.textUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textUsername.MaximumSize = new System.Drawing.Size(151, 40);
            this.textUsername.MinimumSize = new System.Drawing.Size(151, 40);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(151, 40);
            this.textUsername.TabIndex = 3;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.ForeColor = System.Drawing.Color.DeepPink;
            this.textPassword.Location = new System.Drawing.Point(249, 188);
            this.textPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPassword.MaximumSize = new System.Drawing.Size(151, 40);
            this.textPassword.MinimumSize = new System.Drawing.Size(151, 40);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(151, 32);
            this.textPassword.TabIndex = 4;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(218, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin Login";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label1;
    }
}