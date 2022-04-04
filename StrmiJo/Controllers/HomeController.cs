using Microsoft.AspNetCore.Mvc;
using StrmiJo.Services;


namespace StrmiJo.Controllers {
    public class HomeController : Controller {

        private readonly MostPopularDataService _mostPopularDataService;

        public HomeController(MostPopularDataService mostPopularDataService) {
            _mostPopularDataService = mostPopularDataService;
        }
        public IActionResult Index() {           
             return View(_mostPopularDataService.GetAll());
        }

        public IActionResult Privacy() {
            return View();
        }
    }
}
