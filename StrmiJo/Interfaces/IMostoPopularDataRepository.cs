using StrmiJo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrmiJo.Interfaces {
    public interface IMostoPopularDataRepository {
        public MostPopularData GetAll();
    }
}
