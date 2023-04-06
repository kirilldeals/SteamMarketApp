using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamMarketApp.Auth
{
    public class SteamAccount
    {
        public string SteamLoginSecure { get; private set; }
        public string UserID { get; private set; }

        public SteamAccount(string steamLoginSecure)
        {
            SteamLoginSecure = steamLoginSecure;
            UserID = SteamLoginSecure.Substring(0, SteamLoginSecure.IndexOf('%'));
        }
    }
}
