using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Core.Domains;

namespace WebApplication.Infrastructure.Repository
{
    public class PredictionRepository : IPredictionRepository
    {
        protected readonly ApplicationDbContext _context;
        public PredictionRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<Prediction> Get(string _id)
        {
            return await _context.Prediction.FindSync(x => x.Id == _id).SingleAsync();
        }


        public async Task Save(Prediction item)
        {
            await _context.Prediction.InsertOneAsync(item);
        }

        public async Task Delete(Prediction Prediction)
        {
            await _context.Prediction.DeleteOneAsync(x => x.Id == Prediction.Id);
        }

        public async Task Update(Prediction Prediction)
        {

            await _context.Prediction.ReplaceOneAsync(x => x.Id == Prediction.Id, Prediction);

        }

        public async Task<List<Prediction>> FindAll()
        {

            var Predictions = await _context.Prediction.Find("{}").ToListAsync();
            return Predictions;
        }

        public Task<Prediction> FindByPredictionID(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
