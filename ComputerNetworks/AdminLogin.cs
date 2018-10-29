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
        
        private void Submit_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "Admin" && textPassword.Text == "admin1")
            {
                ActiveForm.Close();
                if (PowerScreen.ButtonClicked == "blacklist")
                {
                    blacklist blackForm = new blacklist();
                    blackForm.Show();
                }
                else if (PowerScreen.ButtonClicked == "whitelist")
                {
                    whitelist whiteForm = new whitelist();
                    whiteForm.Show();
                }
                
            }
            else
            {
                SoundPlayer player = new SoundPlayer();
                player.Stop();
                player.SoundLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Noot Noot.wav";
                player.Play();
                MessageBox.Show("Incorrect Username or Password");
                
            }

        }
    }
}
