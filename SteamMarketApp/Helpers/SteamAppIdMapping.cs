using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamMarketApp.Helpers
{
    class SteamAppIdMapping
    {
        public static Dictionary<int, char> Apps { get; } = new Dictionary<int, char>()
        {
            { 753, '6'},
            { 730, '2'},
            { 570, '2'},
            { 578080, '2'},
            { 252490, '1'},
            { 440, '2'},
        };
    }
}
