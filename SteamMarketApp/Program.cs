using SteamMarketApp.Auth;
using SteamMarketApp.Properties;
using System;
using System.Windows.Forms;

namespace SteamMarketApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            if (Settings.Default.IsRemembered)
                Application.Run(
                    new SteamMarketForm(
                        new SteamAccount(
                            Settings.Default.SteamLoginSecure
                            )));
            else
                Application.Run(new SteamLoginForm());
        }
    }
}