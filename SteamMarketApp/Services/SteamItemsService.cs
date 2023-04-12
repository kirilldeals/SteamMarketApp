using Microsoft.Extensions.Options;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;
using MongoDB.Driver;
using SteamMarketApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SteamMarketApp.Services
{
    public class SteamItemsService<TSteamItem> where TSteamItem : ISteamItem, new()
    {
        private readonly IMongoCollection<TSteamItem> _collection;

        public SteamItemsService(IMongoDatabase database, string collection)
        {
            _collection = database.GetCollection<TSteamItem>(collection);
            var indexKeysDefinition = Builders<TSteamItem>.IndexKeys.Ascending(x => x.GrowthRate);
            _collection.Indexes.CreateOne(new CreateIndexModel<TSteamItem>(indexKeysDefinition));

        }

        public long Count()
        {
            var filter = Builders<TSteamItem>.Filter.Empty;
            return _collection.CountDocuments(filter);
        }

        public async Task Create(TSteamItem item)
        {
            await _collection.InsertOneAsync(item);
        }

        public async Task ClearAll()
        {
            var filter = Builders<TSteamItem>.Filter.Empty;
            await _collection.DeleteManyAsync(filter);
        }

        public List<TSteamItem> FindByGrowth(int count, bool desc = true)
        {
            var filter = Builders<TSteamItem>.Filter.Empty;
            var sort = desc ? Builders<TSteamItem>.Sort.Descending("growth_rate") : Builders<TSteamItem>.Sort.Ascending("growth_rate");

            return _collection.Find(filter).Sort(sort).Limit(count).ToList();
        }

        public List<(int,int)> FindPopularApps()
        {
            var filter = Builders<TSteamItem>.Filter.Empty;
            return _collection
                .Find(filter)
                .ToEnumerable()
                .GroupBy(x => x.Appid)
                .OrderByDescending(g => g.Count())
                .Select(g => (Appid: g.Key, Count: g.Count()))
                .ToList();
        }
    }
}
