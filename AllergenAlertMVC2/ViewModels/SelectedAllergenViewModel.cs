using AllergenAlertMVC2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AllergenAlertMVC2.ViewModels
{
    public class SelectedAllergenViewModel
    {

        public AllergenType Allergen { get; set; }

        public List<SelectListItem> AllergenTypes { get; set; }

        //list costructor
        public SelectedAllergenViewModel()
        {
            AllergenTypes = new List<SelectListItem>();
            AllergenTypes.Add(new SelectListItem()
            {
                Value ="0",// ((int)AllergenType.Nuts).ToString(),
                Text ="nuts" //AllergenType.Nuts.ToString()
            });
        }
    }
}
