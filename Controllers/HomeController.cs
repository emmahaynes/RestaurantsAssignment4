using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantsAssignment4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

//Emma Haynes 2-10-21

namespace RestaurantsAssignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Returns the Index.html page
        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>(); //creates a string and loads string with restaurant info
            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                restaurantList.Add($"#{r.Rank}: {r.Name} Favorite Dish: {r.FavDish}, Address: {r.Address}, Phone: {r.Phone}, Website: {r.Website}");
            }
            return View(restaurantList);

        }
        [HttpGet]
        public IActionResult Suggestions()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Suggestions(Suggestions formResponses)
        {
            //checks for correct inputs and then adds response to tempstorage
            if (ModelState.IsValid)
            {
                TempStorage.AddApplication(formResponses);
                return View("Suggestions", formResponses);
            }
            else
            {
                return View();
            }

        }
        public IActionResult List() //returns all responses in tempstorage during the session
        {
            return View(TempStorage.FormResponses);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
