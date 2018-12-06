using System;
using System.Media;
using System.Net.Http;
using System.Windows.Forms;

namespace ComputerNetworks
{
    public partial class PowerScreen : Form
    {
        public static readonly HttpClient client = new HttpClient();

        private static SoundPlayer Noot_Noot = new SoundPlayer(Properties.Resources.Noot_Noot);
        private static SoundPlayer Fur_Elise = new SoundPlayer(Properties.Resources.Beethoven___Für_Elise__Klutch_Dubstep_Trap_Remix_);

        private bool HasOptions = false;

        public PowerScreen()
        {
            client.DefaultRequestHeaders.Add("X-PowerScreen", "1");

            InitializeComponent();
            notifyIcon = new NotifyIcon()
            {
                Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath),
                ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("Open", OpenThisBoy),
                    new MenuItem("Pause Music", PauseMusic)
                    }),
                Visible = false
            };
        }

        public void OpenThisBoy(object sender, EventArgs e)
        {
            this.Show();
        }

        public void PauseMusic(object sender, EventArgs e)
        {
            Fur_Elise.Stop();
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
            // Haha the options button actually closes the program on the second click...
            if(HasOptions)
            {
                Application.ExitThread();
            }
            HasOptions = true;
        }

        private void PowerScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIcon.Visible = true;
                this.Hide();
                e.Cancel = true;
            }
            else if(e.CloseReason == CloseReason.TaskManagerClosing)
            {
                e.Cancel = true;
            }
        }

        private void PowerScreen_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon.Visible = true;
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon.Visible = false;
            }
        }

        private void PowerScreen_Load(object sender, EventArgs e)
        {
            Fur_Elise.PlayLooping();
        }

        private void PowerScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Q)
            {
                Noot_Noot.Play();
            }
        }
    }
}
