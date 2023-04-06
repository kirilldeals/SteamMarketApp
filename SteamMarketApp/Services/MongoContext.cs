using AngleSharp;
using MongoDB.Driver;
using SteamMarketApp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamMarketApp.Services
{
    public class MongoContext
    {
        private readonly IMongoClient _client;
        public IMongoDatabase Database { get; }

        public MongoContext()
        {
            _client = new MongoClient(Settings.Default.ConnectionString);
            Database = _client.GetDatabase(Settings.Default.DatabaseName);
        }
    }
}
