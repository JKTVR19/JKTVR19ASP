using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWorld.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Странa")]
        public string Name { get; set; }

        [Display(Name = "Котинент")]
        public string Continent { get; set; }

        [Display(Name = "Дата основания")]
        public string Year { get; set; }

        [Display(Name = "Столица")]
        public string Capital { get; set; }

        public ICollection<City> Cities { get; set; }
        public Country()
        {
            Cities = new List<City>();
        }
    }
}