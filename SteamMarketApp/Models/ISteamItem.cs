using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamMarketApp.Models
{
    public interface ISteamItem
    {
        public string ItemId { get; set; }

        public string Name { get; set; }

        public int Appid { get; set; }

        public Dictionary<DateTime, double> Prices { get; set; }

        public double GrowthRate { get; set; }
    }

    public interface ISteamItems<ISteamItem>
    {
        public IEnumerable<ISteamItem> Collection { get; set; }
    }
}
