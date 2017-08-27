using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Core.Domains;

namespace WebApplication.Infrastructure.Repository
{
    public interface IStockDataRepository
    {
        Task Delete(StockData StockData);
        Task<List<StockData>> FindAll();
        Task<StockData> FindByStockDataID(string Id);
        Task<StockData> Get(string _id);
        Task Save(StockData item);
        Task Update(StockData StockData);
    }
}