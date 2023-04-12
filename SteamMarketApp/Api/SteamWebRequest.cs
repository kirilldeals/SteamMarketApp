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
        private const string RequestUrl = "https://steamcommunity.com{0}?{1}";

        public static async Task<string> GetAsync(string steamLoginSecure, string method = "", string queryParams = "")
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

                    var result = await httpClient.GetAsync(requestUrl);
                    if (result.IsSuccessStatusCode)
                    {
                        return await result.Content.ReadAsStringAsync();
                    }
                    return "";
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
