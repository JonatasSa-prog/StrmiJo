using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StrmiJo.Model;
using StrmiJo.Services;


namespace StrmiJo.Controllers
{
    public class MovieDetail : Controller
    {
        private readonly TitleDataService _TitleDataService = new TitleDataService();

        public IActionResult Index()
        {
            var movie = JsonConvert.DeserializeObject<TitleData>(HttpContext.Session.GetString("SessionMovie"));
            return View(movie);
        }

        public IActionResult GetMovieId(string id) {

            string messager = string.Empty;
            bool is_action = false;
            string url = string.Empty;

            try {
                var movie = _TitleDataService.GetTitleData(id);
                if (!string.IsNullOrWhiteSpace(movie))
                    HttpContext.Session.SetString("SessionMovie", movie);

                is_action = true;
            } catch {
                messager = "Filme não Encontrado.";
            }

            return Json(new { is_action, messager, url = string.IsNullOrEmpty(url) ? Url.Action("Index", "MovieDetail") : url });
        }
    }
}
