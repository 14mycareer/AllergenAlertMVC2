﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllergenAlertMVC2.Models
{
    public class Restaurant
    {

        public string Name { get; set; }
        public Boolean NoAllergen {get; set;}
        public int ID { get; set; }
        public AllergenType Allergen { get; set; }
        

              
    }
}
