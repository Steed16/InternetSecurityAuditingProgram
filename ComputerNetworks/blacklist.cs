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
            string site = blacklistTextBox.ToString().Substring(blacklistTextBox.ToString().LastIndexOf(':') + 1);
            string category = catagoryCheckList.SelectedItem.ToString().Substring(catagoryCheckList.ToString().LastIndexOf('=') + 1);
            string tagName = tagNameInput.ToString().Substring(tagNameInput.ToString().LastIndexOf(':') + 1).Substring();

            MessageBox.Show(tagName);

            XDocument doc = XDocument.Load(@"C:\Users\steed\Desktop\text.xml");
            XElement root = doc.Element("Blacklisted");
            root.Add(new XElement(tagName,
                     new XElement("Category", category),
                     new XElement("URL", site)));
            doc.Save(@"C:\Users\steed\Desktop\text.xml");
            MessageBox.Show("You Blacklisted '" + tagName + "' under the category " + category);
        }

        private void blacklist_Load(object sender, EventArgs e)
        {
            whitelist.bList = treeView1;
            WebMethods.XmlReader();
        }
    }
}
