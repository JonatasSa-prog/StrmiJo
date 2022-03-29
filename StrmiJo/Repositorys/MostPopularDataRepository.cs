using StrmiJo.Model;
using Newtonsoft.Json;
using System;
using Refit;
using StrmiJo.Interfaces;
using System.Threading.Tasks;
using System.Net.Http;

namespace StrmiJo.Repository {
    public class MostPopularDataRepository {
       
        public MostPopularData GetMostPopularData() {
            string strUrl = "https://imdb-api.com/pt-br/API/MostPopularMovies/k_1hpiy85y";

            HttpClient client = new HttpClient();

            var response = client.GetAsync(strUrl).Result;

            MostPopularData movies = null;

            if (response.IsSuccessStatusCode) {
                var result = response.Content.ReadAsStringAsync().Result;

                movies = JsonConvert.DeserializeObject<MostPopularData>(result);
            }
            return movies;
        }

    }
}
