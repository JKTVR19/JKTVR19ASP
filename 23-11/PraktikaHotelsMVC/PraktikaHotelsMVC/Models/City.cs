using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PraktikaHotelsMVC.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public List<Hotel> Hotels { get; set; }
    }
}