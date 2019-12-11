using AllergenAlertMVC2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllergenAlertMVC2.ViewModels
{
    public class FoundRestaurantViewModel
    {

        [Required]

        public List<Restaurant> Restaurants { get; set; }
    }
}
