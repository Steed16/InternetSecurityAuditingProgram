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
        static string xmlPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\text.xml";\

        public static async void XmlReader()
        {
            XmlDocument doc = await Database.GetBlacklistedWebsites();

            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/Blacklisted/Website");
            string id = "";  string site = "";  string category = "";

            foreach (XmlNode node in nodeList)
            {
                id = node.SelectSingleNode("ID").InnerText;
                site = node.SelectSingleNode("URL").InnerText;
                category = node.SelectSingleNode("Category").InnerText;

                whitelist.BlackListView.Nodes[category].Nodes.Add(id, site);
            }
        }

        public static async void XmlRemove(TreeNode treeNode)
        {
            await Database.WhitelistWebsiteAsync(treeNode.Name).ContinueWith(task =>
            {
                string result = task.Result;
                bool res = Boolean.Parse(result.ToString());
                if (res)
                {
                    MessageBox.Show("You have removed '" + treeNode.Text + "' from being blacklisted");
                }
                else
                {
                    MessageBox.Show("An error occurred. The site '" + treeNode.Text + "' was not removed from the blacklist.");
                }
            });
        }
    }
}