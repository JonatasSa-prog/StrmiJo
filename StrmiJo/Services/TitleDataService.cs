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
        public string GetTitleData(string id)
        {
            string strUrl = "https://imdb-api.com/pt-BR/API/Title/k_1hpiy85y/" + id;
            string result = string.Empty;

            HttpClient client = new HttpClient();

            var response = client.GetAsync(strUrl).Result;

            TitleData movie = null;

            if (response.IsSuccessStatusCode)
            {
               result = response.Content.ReadAsStringAsync().Result;
            }

            return result;
        }
    }
}
