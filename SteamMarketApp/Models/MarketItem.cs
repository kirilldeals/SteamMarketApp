using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamMarketApp.Models
{
    //public class MarketItem
    //{
    //    //[BsonId]
    //    //[BsonRepresentation(BsonType.ObjectId)]
    //    [JsonProperty("asset_description.classid")]
    //    public string ItemId { get; set; }

    //    [JsonProperty("hash_name")]
    //    public string Name { get; set; }

    //    [JsonProperty("asset_description.appid")]
    //    public int AppId { get; set; }

    //    //[BsonElement("increase_index")]
    //    //public double IncreaseIndex { get; set; }
    //    //[BsonElement("price_history")]
    //    //public object PriceHistory { get; set; }
    //}

    public class AssetDescription
    {
        [JsonProperty("appid")]
        public int Appid { get; set; }

        [JsonProperty("classid")]
        public string Classid { get; set; }
    }

    public class MarketItem
    {
        public string ItemId { get { return AssetDescription.Classid; } }

        [JsonProperty("hash_name")]
        public string Name { get; set; }

        public int Appid { get { return AssetDescription.Appid; } }

        public Dictionary<DateTime, double> Prices { get; set; }

        [JsonProperty("asset_description")]
        private AssetDescription AssetDescription { get; set; }
    }

    public class MarketItems
    {
        [JsonProperty("results")]
        public List<MarketItem> Collection { get; set; }
    }
}
