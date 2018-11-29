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
    }
}
