using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllergenAlertMVC2.Models;
using AllergenAlertMVC2.ViewModels;
using AllergenAlertMVC2.Data;

namespace AllergenAlertMVC2.Controllers
{
    public class HomeController : Controller
    {
        private RestaurantDbContext context;

        //constructor that takes instance of data that is of DbContext type
        public HomeController(RestaurantDbContext dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult AddRestaurant(AddRestaurantViewModel addRestaurantViewModel)
        public IActionResult FindRestaurant(FindRestaurantViewModel findRestaurantViewModel)
        {
            int AllergenID = findRestaurantViewModel.AllergenID;
            ViewData["Message"] = "Your allergen id is."+ AllergenID;


            FoundRestaurantViewModel foundRestaurantViewModel = new FoundRestaurantViewModel();
            foundRestaurantViewModel.Restaurants = context.Restaurants.ToList();
            return View(foundRestaurantViewModel);
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
