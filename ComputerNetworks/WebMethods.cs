using System;
using System.Windows.Forms;
using System.Xml;
using System.Threading.Tasks;
using System.Web;
using System.Runtime;
using Microsoft.AspNetCore.WebApi.Client;



namespace ComputerNetworks
{
    internal class WebMethods
    {
        // static string xmlPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\text.xml";

        public static async void XmlReader()
        {
            XmlDocument doc = await Database.GetBlacklistedWebsites();

            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/Blacklisted/Website");
            string id = "";  string site = "";  string category = "";

            foreach(TreeNode node in whitelist.BlackListView.Nodes)
            {
                node.Nodes.Clear();
            }
            
            foreach (XmlNode node in nodeList)
            {
                id = node.SelectSingleNode("ID").InnerText;
                site = node.SelectSingleNode("URL").InnerText;
                category = node.SelectSingleNode("Category").InnerText;

                whitelist.BlackListView.Nodes[category].Nodes.Add(id, site);
            }
        }

        public static async Task<bool> XmlRemove(TreeNode treeNode)
        {
            return await Database.WhitelistWebsiteAsync(treeNode.Name).ContinueWith(task =>
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
                return res;
            });
        }

    }
}