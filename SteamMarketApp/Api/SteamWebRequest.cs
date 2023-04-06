using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SteamMarketApp.Api
{
    public class SteamWebRequest
    {
        private const string SteamCommunityDomain = "steamcommunity.com";
        private const string RequestUrl = "https://steamcommunity.com/{0}?{1}";

        public static async Task<string> GetAsync(string method, string queryParams, string steamLoginSecure)
        {
            while (true)
            {
                try
                {
                    var cookieContainer = new CookieContainer();
                    var httpClientHandler = new HttpClientHandler()
                    {
                        CookieContainer = cookieContainer,
                        UseCookies = true
                    };

                    using var httpClient = new HttpClient(httpClientHandler);
                    httpClient.BaseAddress = new Uri($"https://{SteamCommunityDomain}/");

                    var cookie = new Cookie("steamLoginSecure", steamLoginSecure, null, SteamCommunityDomain);
                    cookieContainer.Add(cookie);

                    var requestUrl = string.Format(RequestUrl, method, queryParams);
                    var response = "";

                    var result = await httpClient.GetAsync(requestUrl);
                    if (result.IsSuccessStatusCode)
                    {
                        response = await result.Content.ReadAsStringAsync();
                    }

                    return response;
                    //HttpWebRequest req = (HttpWebRequest)WebRequest.Create(string.Format(RequestUrl, method, queryParams));
                    //if (req.CookieContainer == null)
                    //{
                    //    Uri target = new Uri($"https://{SteamCommunityDomain}/");
                    //    req.CookieContainer = new CookieContainer();
                    //    Cookie cookie = new Cookie("steamLoginSecure", steamLoginSecure,
                    //        null, SteamCommunityDomain);
                    //    req.CookieContainer.Add(cookie);
                    //}
                    //WebResponse resp = req.GetResponse();
                    //Stream stream = resp.GetResponseStream();
                    //StreamReader sr = new StreamReader(stream);
                    //string output = sr.ReadToEnd();
                    //return output;
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
