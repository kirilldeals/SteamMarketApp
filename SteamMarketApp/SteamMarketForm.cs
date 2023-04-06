using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SteamMarketApp.Api;
using SteamMarketApp.Auth;
using SteamMarketApp.Models;
using SteamMarketApp.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SteamMarketApp
{
    public partial class SteamMarketForm : Form
    {
        private SteamAccount _steamAccount;
        private MongoContext _mongoContext;
        private MarketItemsService _marketItems;

        private static string DateFormat = "MMM dd yyyy HH: z";

        public SteamMarketForm(SteamAccount account)
        {
            InitializeComponent();
            _steamAccount = account;
            _mongoContext = new MongoContext();
            _marketItems = new MarketItemsService(_mongoContext.Database, "market_items");
            MarketItemsService inventoryItems = new MarketItemsService(_mongoContext.Database, "inventory_items");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var result = await SteamWebRequest.GetAsync("/market/search/render", "norender=1&start=0&count=10", _steamAccount.SteamLoginSecure);

            MarketItems marketItems = JsonConvert.DeserializeObject<MarketItems>(result);
            //JObject json = JsonConvert.DeserializeObject<JObject>(result);
            //JArray resultsArray = (JArray)json["results"];
            //IEnumerable<MarketItem> marketItems = resultsArray.Select(x => new MarketItem
            //{
            //    ItemId = (string)x["asset_description"]["classid"],
            //    Name = (string)x["hash_name"],
            //    AppId = (int)x["asset_description"]["appid"]
            //});

            var tasks = marketItems.Collection.Select(async item => await GetPriceHistory(item));
            await Task.WhenAll(tasks);
        }

        private async Task GetPriceHistory(MarketItem item)
        {
            var result = await SteamWebRequest.GetAsync("/market/pricehistory", $"appid={item.Appid}&market_hash_name={HttpUtility.UrlEncode(item.Name)}&currency=5", _steamAccount.SteamLoginSecure);
            JObject json = JsonConvert.DeserializeObject<JObject>(result);
            JArray resultsArray = (JArray)json["prices"];

            // Convert JArray to IEnumerable<MarketItem>
            item.Prices = resultsArray
                .Select(x => new KeyValuePair<DateTime, double>(DateTime.ParseExact((string)x[0], DateFormat, CultureInfo.InvariantCulture), (double)x[1]))
                .ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
