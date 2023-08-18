using SteamMarketApp.Api;
using SteamMarketApp.Auth;
using SteamMarketApp.Properties;
using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Linq;

namespace SteamMarketApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();

            bool isLoggedIn = await IsSteamUserLoggedIn();
            var loginForm = new SteamLoginForm();
            loginForm.FormClosed += (sender, e) => {
                Application.Exit();
            };

            if (isLoggedIn)
            {
                var marketForm = new SteamMarketForm(loginForm, new SteamAccount(Settings.Default.SteamLoginSecure));
                marketForm.Show();
            }
            else
            {
                loginForm.Show();
            }
            Application.Run();
        }

        private static async Task<bool> IsSteamUserLoggedIn()
        {
            if (!Settings.Default.IsRemembered)
            {
                return false;
            }

            var result = await SteamWebRequest.GetAsync(Settings.Default.SteamLoginSecure);
            if (string.IsNullOrEmpty(result))
                return false;
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(result);
            HtmlNode divNode = htmlDoc.GetElementbyId("global_action_menu");
            HtmlNode? accountInfo = divNode.Descendants().FirstOrDefault(n => n.Attributes["id"]?.Value == "account_pulldown");

            return accountInfo != null;
        }
    }
}
