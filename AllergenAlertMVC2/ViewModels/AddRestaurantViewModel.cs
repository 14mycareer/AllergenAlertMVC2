using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace AllergenAlertMVC2.ViewModels
{
    public class AddRestaurantViewModel
    {
        [Required]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        
        public Boolean Nuts { get; set; }
        public Boolean Dairy { get; set; }
        public Boolean Soy { get; set; }


    }
}
