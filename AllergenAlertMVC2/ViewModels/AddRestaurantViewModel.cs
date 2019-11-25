using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System;


namespace AllergenAlertMVC2.ViewModels
{
    public class AddRestaurantViewModel
    {
        [Required]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }

        [Required]
        public Boolean NoAllergen { get; internal set; }


    }
}
