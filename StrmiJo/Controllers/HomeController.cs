using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StrmiJo.Models;
using StrmiJo.Repository;
using StrmiJo.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
