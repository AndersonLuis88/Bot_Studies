using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Bot_Instagram
{
    public static class Instagram
    {
        public static Profile GetProfileByUser(string username)
        {
            var profile = new Profile(username);
            string url = @"https://www.instagram.com/"+username"/";
            string code;
            using (WebClient a = new WebClient())
            {
                code = a.DownloadString(url);
            }
            HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument();
            html.LoadHtml(code);

            var list = html.DocumentNode.SelectNodes("//meta");

            foreach (var node in list)
            {
                string property = node.GetAttributeValue("property", "");

                if(property == "al:ios:app_name")
                {
                    profile.IosAppName = node.GetAttributeValue("content", "");
                }

                if (property == "al:ios:app_store_id")
                {
                    profile.IosAppId = node.GetAttributeValue("content", "");
                }

                if (property == "al:ios:url")
                {
                    profile.IosUrl = node.GetAttributeValue("content", "");
                }













            }
        }
    }
}
