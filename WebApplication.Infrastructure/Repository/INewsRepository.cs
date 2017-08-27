using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Core.Domains;

namespace WebApplication.Infrastructure.Repository
{
    public interface INewsRepository
    {
        Task Delete(News News);
        Task<List<News>> FindAll();
        Task<News> FindByNewsID(string Id);
        Task<News> Get(string _id);
        Task Save(News item);
        Task Update(News News);
    }
}