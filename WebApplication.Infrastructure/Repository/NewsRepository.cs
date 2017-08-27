using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Core.Domains;

namespace WebApplication.Infrastructure.Repository
{
    public class NewsRepository : INewsRepository
    {
        protected readonly ApplicationDbContext _context;
        public NewsRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<News> Get(string _id)
        {
            return await _context.News.FindSync(x => x.Id == _id).SingleAsync();
        }


        public async Task Save(News item)
        {
            await _context.News.InsertOneAsync(item);
        }

        public async Task Delete(News News)
        {
            await _context.News.DeleteOneAsync(x => x.Id == News.Id);
        }

        public async Task Update(News News)
        {

            await _context.News.ReplaceOneAsync(x => x.Id == News.Id, News);

        }

        public async Task<List<News>> FindAll()
        {

            var Newss = await _context.News.Find("{}").ToListAsync();
            return Newss;
        }

        public Task<News> FindByNewsID(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
