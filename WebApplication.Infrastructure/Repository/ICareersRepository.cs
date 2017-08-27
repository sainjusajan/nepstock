using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Core.Domains;

namespace WebApplication.Infrastructure.Repository
{
    public interface ICareersRepository
    {
        Task Delete(Careers Careers);
        Task<List<Careers>> FindAll();
        Task<Careers> FindByCareersID(string Id);
        Task<Careers> Get(string _id);
        Task Save(Careers item);
        Task Update(Careers Careers);
    }
}