using System;
using System.Windows.Forms;

namespace ComputerNetworks
{
    public partial class blacklist : Form
    {
        public blacklist()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            string site = blacklistSiteTextBox.Text;
            string category = selectedCategory.Text;
            string tagName = tagNameInput.Text;

            await Database.BlacklistWebsiteAsync(tagName, category, site).ContinueWith(task =>
            {
                string result = task.Result;
                bool res = Boolean.Parse(result.ToString());
                if (res)
                {
                    MessageBox.Show("You Blacklisted '" + site + "' under the category " + category);
                }
                else
                {
                    MessageBox.Show("An error occurred, '" + site + "' was not added to the blacklist.");
                }
            });
            WebMethods.XmlReader();
        }

        private void Blacklist_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int RandomFactNum = rnd.Next(0, RandomFactList.FactArray.Length);
            whitelist.BlackListView = treeView1;
            RandomFactText.Text = RandomFactList.FactArray[RandomFactNum];
            WebMethods.XmlReader();

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                selectedCategory.Text = ((RadioButton)sender).Text;
            }
        }
    }
}
