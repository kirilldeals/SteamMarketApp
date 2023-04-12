using MongoDB.Driver;
using SteamMarketApp.Properties;

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
