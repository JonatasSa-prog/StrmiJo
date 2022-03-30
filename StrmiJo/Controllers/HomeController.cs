using Microsoft.AspNetCore.Mvc;
using StrmiJo.Services;


namespace StrmiJo.Controllers {
    public class HomeController : Controller {

        private readonly MostPopularDataService mostPopularDataService = new MostPopularDataService();
        public IActionResult Index() {           
             return View(mostPopularDataService.GetAll());
        }

        public IActionResult Privacy() {
            return View();
        }
    }
}
