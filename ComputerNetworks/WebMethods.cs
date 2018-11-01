using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace ComputerNetworks
{
    internal class WebMethods
    {
        static string xmlPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\text.xml";

        public static void XmlReader()
        {
            /*
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(xmlPath);
            }
            catch (Exception)
            {
                doc.LoadXml("<BlackListed />");
            }
            */
            XmlDocument doc = Database.GetBlacklistedWebsites();

            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/Blacklisted/Website");
            string category = ""; string site = ""; string tagName = "";

            foreach (XmlNode node in nodeList)
            {
                tagName = node.SelectSingleNode("TagName").InnerText;
                category = node.SelectSingleNode("Category").InnerText;
                site = node.SelectSingleNode("URL").InnerText;

                if (category == "Social Media" || category == "Gaming" || category == "NSFW" || category == "Other")
                {
                    whitelist.BlackListView.Nodes[category].Nodes.Add(tagName);
                } else
                {
                    MessageBox.Show("Invalid category.");
                }
            }
        }

        public static void XmlRemove(TreeNode treeNode)
        {
            /*
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(xmlPath);
            }
            catch (Exception)
            {
                doc.LoadXml("<BlackListed />");
            }
            */
            XmlDocument doc = Database.GetBlacklistedWebsites();

            var nodeList = doc.DocumentElement.SelectNodes("/Blacklisted/Website");
            string category = ""; string site = ""; string tagName = "";

            foreach (XmlNode node in nodeList)
            {
                tagName = node.SelectSingleNode("TagName").InnerText;
                category = node.SelectSingleNode("Category").InnerText;
                site = node.SelectSingleNode("URL").InnerText;

                if (tagName == treeNode.Text)
                {
                    if (category == "Social Media" || category == "Gaming" || category == "NSFW" || category == "Other")
                    {
                        XmlNodeList nodes = doc.GetElementsByTagName(tagName);

                        node.ParentNode.RemoveChild(node);
                    } else {
                        MessageBox.Show("Invalid category.");
                        return;
                    }

                    Database.WhitelistWebsiteAsync(tagName, category, site).ContinueWith(task =>
                    {
                        string result = task.Result;
                        bool res = Boolean.Parse(result.ToString());
                        if (res)
                        {
                            MessageBox.Show("You have removed '" + site + "' from being blacklisted");
                        } else
                        {
                            MessageBox.Show("An error occurred, '" + site + "' was not removed from the blacklist.");
                        }
                    });
                }
            }
        }
    }
}