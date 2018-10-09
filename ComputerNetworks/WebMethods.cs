using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ComputerNetworks
{
    class WebMethods
    {

        public static void XmlReader()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\steed\Desktop\text.xml");
            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/Blacklisted/Website");
            string category = ""; string site = "";

            foreach (XmlNode node in nodeList)
            {
                category = node.SelectSingleNode("Category").InnerText;
                site = node.SelectSingleNode("URL").InnerText;

                if (category == "Social media")
                {
                    whitelist.bList.Nodes["Social media"].Nodes.Add(site);
                }
                else if (category == "Gaming")
                {
                    whitelist.bList.Nodes["Gaming"].Nodes.Add(site);
                }
                else if (category == "NSFW")
                {
                    whitelist.bList.Nodes["NSFW"].Nodes.Add(site);
                }
                else if (category == "Other")
                {
                    whitelist.bList.Nodes["Other"].Nodes.Add(site);
                }
            }
        }

        public static void XmlRemove()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\steed\Desktop\text.xml");
            var nodeList = doc.DocumentElement.SelectNodes("/Blacklisted/Website");
            string category = ""; string site = "";

            foreach (XmlNode node in nodeList)
            {
                category = node.SelectSingleNode("Category").InnerText;
                site = node.SelectSingleNode("URL").InnerText;

                if (category == "Social media")
                {

                    XmlNodeList nodes = doc.GetElementsByTagName(site);

                    node.ParentNode.RemoveChild(node);
                    doc.Save(@"C:\Users\steed\Desktop\text.xml");
                }
                else if (category == "Gaming")
                {
                    XmlNodeList nodes = doc.GetElementsByTagName(site);

                    node.ParentNode.RemoveChild(node);
                    doc.Save(@"C:\Users\steed\Desktop\text.xml");
                }
                else if (category == "NSFW")
                {
                    XmlNodeList nodes = doc.GetElementsByTagName(site);

                    node.ParentNode.RemoveChild(node);
                    doc.Save(@"C:\Users\steed\Desktop\text.xml");
                }
                else if (category == "Other")
                {
                    XmlNodeList nodes = doc.GetElementsByTagName(site);

                    node.ParentNode.RemoveChild(node);
                    doc.Save(@"C:\Users\steed\Desktop\text.xml");
                }
                MessageBox.Show("You hav removed '" + site + "' from being blacklisted");
            }
        }
        
    }
}
