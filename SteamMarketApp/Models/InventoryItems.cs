using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamMarketApp.Models
{
    [BsonIgnoreExtraElements]
    public class InventoryItem : ISteamItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ItemId { get; set; }

        [BsonElement("name")]
        [JsonProperty("market_hash_name")]
        public string Name { get; set; }

        [BsonElement("appid")]
        [JsonProperty("appid")]
        public int Appid { get; set; }

        [BsonElement("prices")]
        [BsonDictionaryOptions(DictionaryRepresentation.ArrayOfDocuments)]
        public Dictionary<DateTime, double> Prices { get; set; }

        [BsonElement("growth_rate")]
        public double GrowthRate { get; set; }

        [JsonProperty("marketable")]
        public bool Marketable { get; set; }
    }

    public class InventoryItems : ISteamItems<InventoryItem>
    {
        [JsonProperty("descriptions")]
        public IEnumerable<InventoryItem> Collection { get; set; }
    }
}
