using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StrmiJo.Model;
using StrmiJo.Services;


namespace StrmiJo.Controllers {
    public class MovieDetail : Controller {
        private readonly TitleDataService _TitleDataService = new TitleDataService();

        public IActionResult Index(string id) {
            var movie = GetMovieId2(id);
            return View(movie);
        }

        public TitleData GetMovieId2(string id) {

            var movie = _TitleDataService.GetTitleData(id);
            if (movie != null)
                return movie;

            return null;
        }
    }
}
