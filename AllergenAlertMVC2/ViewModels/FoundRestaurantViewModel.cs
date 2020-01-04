using AllergenAlertMVC2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AllergenAlertMVC2.ViewModels;
using AllergenAlertMVC2.Data;

namespace AllergenAlertMVC2.ViewModels
{
    
    public class FoundRestaurantViewModel
    {
        public FoundRestaurantViewModel()
        // : base(options)
        { Restaurants = new List<Restaurant>(); }

        [Required]

        public List<Restaurant> Restaurants { get; set; }
    }
}
