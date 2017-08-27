//using MongoDB.Driver;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using WebApplication.Core.Domains;

//namespace WebApplication.Infrastructure.Repository
//{
//    public class StockDataRepository : IStockDataRepository
//    {
//        protected readonly ApplicationDbContext _context;
//        public StockDataRepository(ApplicationDbContext context)
//        {
//            _context = context;
//        }


//        public async Task<StockData> Get(string _id)
//        {
//            return await _context.StockData.FindSync(x => x.Id == _id).SingleAsync();
//        }
//        public virtual Task<StockData> FindByStockDataID(string Id)
//        {
//            if (string.IsNullOrWhiteSpace(Id)) return Task.FromResult((StockData)null);

//            var filter = Builders<StockData>.Filter.Eq(x => x.Id, Id);
//            var options = new FindOptions { AllowPartialResults = false };

//            return _context.StockData.Find(filter, options).SingleOrDefaultAsync();

//        }


//        public async Task Save(StockData item)
//        {
//            await _context.StockData.InsertOneAsync(item);
//        }

//        public async Task Delete(StockData StockData)
//        {
//            await _context.StockData.DeleteOneAsync(x => x.Id == StockData.Id);
//        }

//        public async Task Update(StockData StockData)
//        {

//            await _context.StockData.ReplaceOneAsync(x => x.Id == StockData.Id, StockData);

//        }

//        public async Task<List<StockData>> FindAll()
//        {

//            var StockDatas = await _context.StockData.Find("{}").ToListAsync();
//            return StockDatas;
//        }
//    }
//}
