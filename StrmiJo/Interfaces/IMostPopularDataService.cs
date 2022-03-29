using Refit;
using StrmiJo.Model;
using System.Threading.Tasks;

namespace StrmiJo.Interfaces {
    public interface IMostPopularDataService {
        [Get("pt-br/API/MostPopularMovies/{apikey}")]
        Task<MostPopularData> GetMostPopularDataAsync(string apikey);
    }
}
