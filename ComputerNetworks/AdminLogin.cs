using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerNetworks
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }
        
        private void submit_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "Admin" && textPassword.Text == "admin1")
            {
                ActiveForm.Close();
                if (Form1.whichOne == "blacklist")
                {
                    blacklist blackForm = new blacklist();
                    blackForm.Show();
                }
                else if (Form1.whichOne == "whitelist")
                {
                    whitelist whiteForm = new whitelist();
                    whiteForm.Show();
                }
                
            }
            else
            {
                SoundPlayer player = new SoundPlayer();
                player.Stop();
                player.SoundLocation = @"C:\Users\steed\Downloads\Noot Noot.wav";
                player.Play();
                MessageBox.Show("Incorrect Username or Password");
                
            }

        }
    }
}
