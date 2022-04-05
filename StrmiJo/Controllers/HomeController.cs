using Microsoft.AspNetCore.Mvc;
using StrmiJo.Services;


namespace StrmiJo.Controllers
{
    public class HomeController : Controller
    {

        private readonly static MostPopularDataService _mostPopularDataService = new MostPopularDataService();
        private readonly TitleDataService _TitleDataService =  new TitleDataService();

        public HomeController()
        {
            //_mostPopularDataService = mostPopularDataService;
        }
        public IActionResult Index()
        {
            return View(_mostPopularDataService.GetAll());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetMovieId(string id)
        {

            string messager = string.Empty;
            bool is_action = false;
            string url = string.Empty;

            try
            {
                var movie = _TitleDataService.GetTitleData(id);
                if (movie != null)
                    messager = "Filme Encontrado.";
            }
            catch
            {
                messager = "Filme não Encontrado.";
            }

            return Json(new { is_action, messager, url = string.IsNullOrEmpty(url) ? Url.Action("Index", "Dashboard") : url });
        }
    }
}
