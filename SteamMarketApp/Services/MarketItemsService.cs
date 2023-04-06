using Microsoft.Extensions.Options;
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
    public class MarketItemsService
    {
        private readonly IMongoCollection<MarketItem> _gamesCollection;

        public MarketItemsService(IMongoDatabase database, string collection)
        {
            _gamesCollection = database.GetCollection<MarketItem>(collection);
        }

        public List<MarketItem> Get()
        {
            return _gamesCollection.Find(_ => true).ToList();
        }

        public MarketItem Get(string id)
        {
            return _gamesCollection.Find(x => x.ItemId == id).FirstOrDefault();
        }

        public List<MarketItem> Where(Expression<Func<MarketItem, bool>> filter)
        {
            return _gamesCollection.Find(filter).ToList();
        }

        public void Create(MarketItem game)
        {
            _gamesCollection.InsertOne(game);
        }
        public void Update(string id, MarketItem updatedGame)
        {
            _gamesCollection.ReplaceOne(x => x.ItemId == id, updatedGame);
        }

        public void Remove(string id)
        {
            _gamesCollection.DeleteOne(x => x.ItemId == id);
        }
    }
}
