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

        public async Task CreateAsync(TSteamItem item)
        {
            await _collection.InsertOneAsync(item);
        }

        public async Task ClearAllAsync()
        {
            var filter = Builders<TSteamItem>.Filter.Empty;
            await _collection.DeleteManyAsync(filter);
        }

        public List<TSteamItem> FindByGrowth(int count, bool desc = true)
        {
            var filter = Builders<TSteamItem>.Filter.Empty;
            var sort = desc ? 
                Builders<TSteamItem>.Sort.Descending(item => item.GrowthRate) : 
                Builders<TSteamItem>.Sort.Ascending(item => item.GrowthRate);

            return _collection.Find(filter).Sort(sort).Limit(count).ToList();
        }

        public List<TSteamItem> FindByPrice(int count, bool desc = true)
        {
            var filter = Builders<TSteamItem>.Filter.Empty;
            var items = _collection.Find(filter).ToEnumerable();

            var sortedItems = desc ?
                items.OrderByDescending(item => item.Prices.Values.Last()) :
                items.OrderBy(item => item.Prices.Values.Last());

            return sortedItems.Take(count).ToList();
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
