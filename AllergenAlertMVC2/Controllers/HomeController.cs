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
        //private IEnumerable<Restaurant> Restarants;

       // public IEnumerable<Restaurant> Restaurants { get; private set; }

        //constructor that takes instance of data that is of DbContext type
        public HomeController(RestaurantDbContext dbContext)
        {
            context = dbContext;
        }

        

        //gets/displays dropdownlist
        public IActionResult Index()
        {
            return View();
        }

        //method to find restaurant that matches dropdownlist "value" int
        //public IActionResult AddRestaurant(AddRestaurantViewModel addRestaurantViewModel)
        public IActionResult FindRestaurant(FindRestaurantViewModel findRestaurantViewModel)
        {
            List<Restaurant> restaurants = context.Restaurants.ToList();

            int AllergenID = findRestaurantViewModel.AllergenID;
            ViewData["Message"] = "ALLERGEN FREE RESTAURANTS";

            FoundRestaurantViewModel foundRestaurantViewModel = new FoundRestaurantViewModel();


            //create listing of restaurants that match the selected allergen & with "true" that have allergen free foods

            
            if (AllergenID == 0)
                foreach (Restaurant r in restaurants)
                    if (r.Nuts == true)
                      foundRestaurantViewModel.Restaurants.Add(r);

                      
            return View(foundRestaurantViewModel);
        }

        //method to display details of selected restaurant
        public IActionResult RestaurantDetails(int restaurantid)
        {
            ViewData["Message"] = "RESTAURANT DETAILS";

            Restaurant restaurant = context.Restaurants.Single(r => r.ID == restaurantid);

            return View(restaurant);
            
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
