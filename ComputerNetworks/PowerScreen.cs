using System;
using System.Net.Http;
using System.Windows.Forms;

namespace ComputerNetworks
{
    public partial class PowerScreen : Form
    {
        public static readonly HttpClient client = new HttpClient();

        public PowerScreen()
        {
            client.DefaultRequestHeaders.Add("X-PowerScreen", "1");

            InitializeComponent();
        }

        public static string ButtonClicked = "";

        private void Button_1_Click(object sender, EventArgs e)
        {
            ButtonClicked = "whitelist";
            AdminLogin blackLogin = new AdminLogin();
            blackLogin.Show();
        }

        private void Button_2_Click(object sender, EventArgs e)
        {
            ButtonClicked = "blacklist";
            AdminLogin blackLogin = new AdminLogin();
            blackLogin.Show();
        }

        private void Button_3_Click(object sender, EventArgs e)
        {
            ButtonClicked = "options";
            MessageBox.Show("Who do you think we are??? Who need options noob!");
        }

        private void PowerScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(500);
                this.Hide();
                e.Cancel = true;
            }
        }

        private void PowerScreen_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }
    }
}
