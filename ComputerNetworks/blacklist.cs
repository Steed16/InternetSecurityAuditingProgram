using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ComputerNetworks
{
    public partial class blacklist : Form
    {
        public blacklist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string site = blacklistTextBox.Text;
            string category = selectedCategory.Text;
            string tagName = tagNameInput.Text;

            XDocument doc = null;
            try
            {
                doc = XDocument.Load(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\text.xml");
            } catch (Exception)
            {
                doc = new XDocument(new XElement("Blacklisted"));
            }
            XElement root = doc.Element("Blacklisted");
            root.Add(new XElement("Website",
                     new XElement("TagName", tagName),
                     new XElement("Category", category),
                     new XElement("URL", site)));
            doc.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\text.xml");
            MessageBox.Show("You Blacklisted '" + tagName + "' under the category " + category);
        }

        private void blacklist_Load(object sender, EventArgs e)
        {
            whitelist.bList = treeView1;
            WebMethods.XmlReader();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                selectedCategory.Text = ((RadioButton)sender).Text.ToString();
            }
        }
    }
}
