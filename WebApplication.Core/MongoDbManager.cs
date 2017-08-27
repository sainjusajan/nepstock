using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Core
{
           public class MongoDbManager : IMongoDbManager
        {
            private MongoClient _client;
            private IMongoDatabase _database;

            public MongoDbManager()
            {
                //"mongodb://localhost:27017"           
            }

            public void Connect(string dbUrl)
            {
                _client = new MongoClient(dbUrl);
            }

            public IMongoDatabase GetDatabase(string dbName)
            {
                _database = _client.GetDatabase(dbName);

                return _database;
            }

            public IMongoCollection<TEntity> GetCollection<TEntity>(string collectionName)
            {
                return _database.GetCollection<TEntity>(collectionName);
            }

            public void SetDatabase(string dbName)
            {
                _database = _client.GetDatabase(dbName);
            }
        }
    
}
