using System;
using System.Windows.Forms;

namespace ComputerNetworks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string whichOne = "";

        private void button1_Click(object sender, EventArgs e)
        {
            whichOne = "whitelist";
            AdminLogin blackLogin = new AdminLogin();
            blackLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            whichOne = "blacklist";
            AdminLogin blackLogin = new AdminLogin();
            blackLogin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Who do you think we are??? Who need options noob!");
        }
    }
}
