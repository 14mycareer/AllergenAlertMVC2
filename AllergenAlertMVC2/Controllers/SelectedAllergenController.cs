using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllergenAlertMVC2.Controllers
{
    public class SelectedAllergenController : Controller
    {

        List<SelectListItem> allergenList = new List<SelectListItem>();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //method to retrieve selected allergen from dropdownlist

        [HttpPost]
        public IActionResult (allergenList)
    

    }
}
