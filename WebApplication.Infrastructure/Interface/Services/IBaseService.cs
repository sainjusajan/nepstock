using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Infrastructure.Interface.Services
{
    public interface IBaseService<TEntity> : IDisposable where TEntity : class

    {
        TEntity Get(ObjectId id);

        List<TEntity> GetAll();

        void Create(TEntity entity);

        bool Delete(ObjectId id);

        void Update(ObjectId id, TEntity entity);
    }
}

