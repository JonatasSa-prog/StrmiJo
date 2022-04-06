using Newtonsoft.Json;
using StrmiJo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StrmiJo.Services
{
    public class TitleDataService
    {
 
        public TitleData GetTitleData(string id) {
            string strUrl = "https://imdb-api.com/pt-BR/API/Title/k_1hpiy85y/" + id;

            HttpClient client = new HttpClient();

            var response = client.GetAsync(strUrl).Result;

            TitleData movie = null;

            if (response.IsSuccessStatusCode) {
                var result = response.Content.ReadAsStringAsync().Result;
                movie = JsonConvert.DeserializeObject<TitleData>(result);
            }

            return movie;
        }
    }
}
