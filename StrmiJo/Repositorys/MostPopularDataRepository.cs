using StrmiJo.Model;
using Newtonsoft.Json;
using System.Net.Http;
using StrmiJo.Interfaces;
using StrmiJo.Data;

namespace StrmiJo.Repository {
    public class MostPopularDataRepository : IMostoPopularDataRepository {

        private readonly DataContext _context;

        public MostPopularDataRepository() {
            _context = new DataContext();
        }

        public MostPopularData GetAll() {
            return _context.MostPopularData;
        }

    }
}
