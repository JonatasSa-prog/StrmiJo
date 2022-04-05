using Newtonsoft.Json;
using StrmiJo.Model;
using System.Net.Http;

namespace StrmiJo.Data {
    public class DataContext{
        public MostPopularData MostPopularData { get; set; }       
        public DataContext() {
            MostPopularData = GetMostPopularData();
        }
        private MostPopularData GetMostPopularData() {
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
