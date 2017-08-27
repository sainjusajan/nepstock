using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Infrastructure.Interface.Services;

namespace WebApplication.Infrastructure.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class

    {
        private IMongoCollection<TEntity> _mongoCollection;

        private ApplicationDbContext _context;

        public BaseService(ApplicationDbContext context)
        {
            _context = context;
        }

        protected void Set(IMongoCollection<TEntity> mongoCollection)
        {
            _mongoCollection = mongoCollection;
        }

        public void Create(TEntity entity)
        {
            _mongoCollection.InsertOneAsync(entity);
        }

        public bool Delete(ObjectId id)
        {
            var query = Builders<TEntity>.Filter.Eq("_id", id);
            var result = _mongoCollection.DeleteOneAsync(query);

            return Get(id) == null;
        }

        public TEntity Get(ObjectId id)
        {
            var query = Builders<TEntity>.Filter.Eq("_id", id);
            var speaker = _mongoCollection.Find(query).ToListAsync();

            return speaker.Result.FirstOrDefault();
        }

        public List<TEntity> GetAll()
        {
            var entities = _mongoCollection.AsQueryable<TEntity>().ToList<TEntity>();
            return entities;
        }

        public void Update(ObjectId id, TEntity entity)
        {
            var query = Builders<TEntity>.Filter.Eq("_id", id);
            var update = _mongoCollection.ReplaceOneAsync(query, entity);
        }

        public void Dispose()
        {

        }





    }
}
