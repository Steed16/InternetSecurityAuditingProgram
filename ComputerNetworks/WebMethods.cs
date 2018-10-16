using System.Windows.Forms;
using System.Xml;

namespace ComputerNetworks
{
    internal class WebMethods
    {
        public static void XmlReader()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\steed\Desktop\text.xml");
            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/Blacklisted/Website");
            string category = ""; string site = ""; string tagName = "";
            
            foreach (XmlNode node in nodeList)
            {
                tagName = node.SelectSingleNode("TagName").InnerText;
                category = node.SelectSingleNode("Category").InnerText;
                site = node.SelectSingleNode("URL").InnerText;

                if (category == "Social media")
                {
                    whitelist.bList.Nodes["Social media"].Nodes.Add(tagName);
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
            doc.Load(@"C:\Users\steed\Desktop\text.xml");
            var nodeList = doc.DocumentElement.SelectNodes("/Blacklisted/Website");

            foreach (XmlNode node in nodeList)
            {
                tagName = node.SelectSingleNode("TagName").InnerText.ToString();
                category = node.SelectSingleNode("Category").InnerText;
                site = node.SelectSingleNode("URL").InnerText;

                if (tagName == treeNode.Text)
                {
                    if (category == "Social media")
                    {
                        XmlNodeList nodes = doc.GetElementsByTagName(tagName);

                        node.ParentNode.RemoveChild(node);
                        doc.Save(@"C:\Users\steed\Desktop\text.xml");
                    }
                    if (category == "Gaming")
                    {
                        XmlNodeList nodes = doc.GetElementsByTagName(tagName);

                        node.ParentNode.RemoveChild(node);
                        doc.Save(@"C:\Users\steed\Desktop\text.xml");
                    }
                    if (category == "NSFW")
                    {
                        XmlNodeList nodes = doc.GetElementsByTagName(tagName);

                        node.ParentNode.RemoveChild(node);
                        doc.Save(@"C:\Users\steed\Desktop\text.xml");
                    }
                    if (category == "Other")
                    {
                        XmlNodeList nodes = doc.GetElementsByTagName(tagName);

                        node.ParentNode.RemoveChild(node);
                        doc.Save(@"C:\Users\steed\Desktop\text.xml");
                    }
                    MessageBox.Show("You hav removed '" + site + "' from being blacklisted");
                }
            }

            
        }
    }
}