using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Web;
using System.Net.Http;

namespace ComputerNetworks
{
    internal class WebMethods
    {
        static string xmlPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\text.xml";
        

        public static void XmlReader()
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(xmlPath);
            }
            catch (Exception)
            {
                doc.LoadXml("<BlackListed></BlackListed>");
            }
            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/Blacklisted/Website");
            string category = ""; string site = ""; string tagName = "";

            foreach (XmlNode node in nodeList)
            {
                tagName = node.SelectSingleNode("TagName").InnerText;
                category = node.SelectSingleNode("Category").InnerText;
                site = node.SelectSingleNode("URL").InnerText;

                if (category == "Social Media")
                {
                    whitelist.bList.Nodes["Social Media"].Nodes.Add(tagName);
                }
                else if (category == "Gaming")
                {
                    whitelist.bList.Nodes["Gaming"].Nodes.Add(tagName);
                }
                else if (category == "NSFW")
                {
                    whitelist.bList.Nodes["NSFW"].Nodes.Add(tagName);
                }
                else if (category == "Other")
                {
                    whitelist.bList.Nodes["Other"].Nodes.Add(tagName);
                }
            }
        }

        public static void XmlRemove(TreeNode treeNode)
        {
            string category = ""; string site = ""; string tagName = "";
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(xmlPath);
            }
            catch (Exception)
            {
                doc.LoadXml("<BlackListed></BlackListed>");
            }
            var nodeList = doc.DocumentElement.SelectNodes("/Blacklisted/Website");

            foreach (XmlNode node in nodeList)
            {
                tagName = node.SelectSingleNode("TagName").InnerText.ToString();
                category = node.SelectSingleNode("Category").InnerText;
                site = node.SelectSingleNode("URL").InnerText;

                if (tagName == treeNode.Text)
                {
                    if (category == "Social Media")
                    {
                        XmlNodeList nodes = doc.GetElementsByTagName(tagName);

                        node.ParentNode.RemoveChild(node);
                        doc.Save(xmlPath);
                    }
                    if (category == "Gaming")
                    {
                        XmlNodeList nodes = doc.GetElementsByTagName(tagName);

                        node.ParentNode.RemoveChild(node);
                        doc.Save(xmlPath);
                    }
                    if (category == "NSFW")
                    {
                        XmlNodeList nodes = doc.GetElementsByTagName(tagName);

                        node.ParentNode.RemoveChild(node);
                        doc.Save(xmlPath);
                    }
                    if (category == "Other")
                    {
                        XmlNodeList nodes = doc.GetElementsByTagName(tagName);

                        node.ParentNode.RemoveChild(node);
                        doc.Save(xmlPath);
                    }
                    MessageBox.Show("You hav removed '" + site + "' from being blacklisted");
                }
            }


        }
    }
}