using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            AllergenTypes.Add(new SelectListItem
            {
                Value = ((int)AllergenType.Nuts).ToString(),
                Text = AllergenType.Nuts.ToString()
            });
        }
    }
}
