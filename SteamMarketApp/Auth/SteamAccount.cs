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
        public string SteamID { get; private set; }

        public SteamAccount(string steamLoginSecure)
        {
            SteamLoginSecure = steamLoginSecure;
            SteamID = SteamLoginSecure.Substring(0, SteamLoginSecure.IndexOf('%'));
        }
    }
}
