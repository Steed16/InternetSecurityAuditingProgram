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
            string cite = blacklistTextBox.ToString().Substring(blacklistTextBox.ToString().LastIndexOf(':') + 1);
            string category = catagoryCheckList.SelectedItem.ToString().Substring(catagoryCheckList.ToString().LastIndexOf('=') + 1);

            //using (XmlWriter writer = XmlWriter.Create(@"C:\Users\Steed16\Desktop\text.xml"))
            //{
            //    writer.WriteStartDocument();
            //    writer.WriteStartElement("Blacklisted");

            //    writer.WriteStartElement("Website");
            //    writer.WriteElementString("Category", category);
            //    writer.WriteElementString("URL", cite);

            //    writer.WriteEndElement();
            //    writer.Flush();
            //}

            XDocument doc = XDocument.Load(@"C:\Users\Steed16\Desktop\text.xml");
            XElement root = doc.Element("Blacklisted");
            root.Add(new XElement("Website",
                     new XElement("Category", category),
                     new XElement("URL", cite)));
            doc.Save(@"C:\Users\Steed16\Desktop\text.xml");
        }
    }
}
