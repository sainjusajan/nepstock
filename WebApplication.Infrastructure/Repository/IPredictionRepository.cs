using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Core.Domains;

namespace WebApplication.Infrastructure.Repository
{
    public interface IPredictionRepository
    {
        Task Delete(Prediction Prediction);
        Task<List<Prediction>> FindAll();
        Task<Prediction> FindByPredictionID(string Id);
        Task<Prediction> Get(string _id);
        Task Save(Prediction item);
        Task Update(Prediction Prediction);
    }
}