using StrmiJo.Model;
using StrmiJo.Repository;
using System.Linq;

namespace StrmiJo.Services {
    public class MostPopularDataService {
        private readonly MostPopularDataRepository _mostPopularDataRepository;

        public MostPopularDataService() {
            _mostPopularDataRepository = new MostPopularDataRepository();
        }
        public MostPopularData GetAll() {
            return _mostPopularDataRepository.GetAll();
        }

        public void GetTopNine()
        {
            this.GetAll().Items = this.GetAll().Items.Take(9).ToList();
        }
    }
}
