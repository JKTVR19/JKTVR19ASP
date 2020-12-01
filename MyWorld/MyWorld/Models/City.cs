using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyWorld.Models
{
    public class City
    {
        public int Id { get; set; }

        [Display(Name = "Название города")]
        public string Name { get; set; }

        [Display(Name = "Население")]
        public int Population { get; set; }
        
        public int? CountryId { get; set; }
        public Country Country { get; set; }
    }
}
