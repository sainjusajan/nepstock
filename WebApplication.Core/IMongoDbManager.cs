using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Core
{
    public interface IMongoDbManager
    {
        IMongoDatabase GetDatabase(string dbName);

        IMongoCollection<TEntity> GetCollection<TEntity>(string collectionName);

        void SetDatabase(string dbName);

        void Connect(string dbUrl);
    }
}
