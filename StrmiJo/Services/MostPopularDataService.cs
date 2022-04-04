using StrmiJo.Model;
using StrmiJo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrmiJo.Services {
    public class MostPopularDataService {
        private readonly MostPopularDataRepository _mostPopularDataRepository;

        public MostPopularDataService() {
            _mostPopularDataRepository = new MostPopularDataRepository();
        }
        public MostPopularData GetAll() {
            return _mostPopularDataRepository.GetAll();
        }
    }
}
