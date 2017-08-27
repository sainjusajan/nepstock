using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using System.Threading.Tasks;
using WebApplication.Core.Domains;
using MongoDB.Driver;

namespace WebApplication.Infrastructure.Repository
{
    public class CareersRepository : ICareersRepository
    {
        protected readonly ApplicationDbContext _context;
        public CareersRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<Careers> Get(string _id)
        {
            return await _context.Careers.FindSync(x => x.Id == _id).SingleAsync();
        }



        public async Task Save(Careers item)
        {
            await _context.Careers.InsertOneAsync(item);
        }

        public async Task Delete(Careers Careers)
        {
            await _context.Careers.DeleteOneAsync(x => x.Id == Careers.Id);
        }

        public async Task Update(Careers Careers)
        {

            await _context.Careers.ReplaceOneAsync(x => x.Id == Careers.Id, Careers);

        }

        public async Task<List<Careers>> FindAll()
        {

            var Careerss = await _context.Careers.Find("{}").ToListAsync();
            return Careerss;
        }

        public Task<Careers> FindByCareersID(string Id)
        {
            throw new NotImplementedException();
        }
    }
}
