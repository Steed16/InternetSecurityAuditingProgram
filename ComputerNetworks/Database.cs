using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace ComputerNetworks
{
    class Database
    {
        public static readonly string BlacklistUrl = "http://isap.ahabedank.com/blacklist.php";

        private static XmlDocument CachedBlacklist { get; set; }

        public static async Task<bool> IsBlacklistedAsync(string website)
        {
            if (CachedBlacklist == null)
            {
                await GetBlacklistedWebsites();
            }
            try
            {
                XmlNodeList nodeList = CachedBlacklist.DocumentElement.SelectNodes("/Blacklisted/Website");
                foreach (XmlNode node in nodeList)
                {
                    if (website == node.SelectSingleNode("URL").InnerText) return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return false;
        }

        public static async Task<XmlDocument> GetBlacklistedWebsites()
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                HttpResponseMessage res = await PowerScreen.client.GetAsync(BlacklistUrl);
                string response = await res.Content.ReadAsStringAsync();

                doc.LoadXml(response);
            }
            catch (Exception)
            {
                doc.LoadXml("<BlackListed />");
            }

            CachedBlacklist = doc;

            return doc;
        }

        public static async Task<string> BlacklistWebsiteAsync(string tagName, string category, string URL)
        {
            var values = new Dictionary<string, string>
            {
                { "tagName", tagName },
                { "category", category },
                { "siteUrl", URL },
                { "action", "blacklist" }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await PowerScreen.client.PostAsync(BlacklistUrl, content);

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }

        public static async Task<string> WhitelistWebsiteAsync(string id)
        {
            var values = new Dictionary<string, string>
            {
                { "id", id },
                { "action", "whitelist" }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await PowerScreen.client.PostAsync(BlacklistUrl, content);

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }
    }
}
