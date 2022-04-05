using Microsoft.AspNetCore.Mvc;
using StrmiJo.Services;


namespace StrmiJo.Controllers
{
    public class HomeController : Controller
    {

        private readonly static MostPopularDataService _mostPopularDataService = new MostPopularDataService();
        

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

        
    }
}
