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
    public class AssetDescription
    {
        [JsonProperty("appid")]
        public int Appid { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class MarketItem : ISteamItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ItemId { get; set; } = null!;

        [BsonElement("name")]
        [JsonProperty("hash_name")]
        public string Name { get; set; } = null!;

        [BsonElement("appid")]
        public int Appid { 
            get 
            { 
                return AssetDescription.Appid; 
            } 
            set 
            { 
                if (AssetDescription == null)
                    AssetDescription = new AssetDescription();
                AssetDescription.Appid = value;                        
            } 
        }

        [BsonElement("prices")]
        [BsonDictionaryOptions(DictionaryRepresentation.ArrayOfDocuments)]
        public Dictionary<DateTime, double> Prices { get; set; } = new Dictionary<DateTime, double>();

        [BsonElement("growth_rate")]
        public double GrowthRate { get; set; }

        [JsonProperty("asset_description")]
        private AssetDescription AssetDescription { get; set; } = null!;
    }

    public class MarketItems : ISteamItems<MarketItem>
    {
        [JsonProperty("results")]
        public IEnumerable<MarketItem> Collection { get; set; } = null!;
    }
}
