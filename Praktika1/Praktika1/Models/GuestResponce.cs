using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Praktika1.Models
{
    public class GuestResponce
    {
        [Required(ErrorMessage = "Please enter you name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email adress")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Please enter a valid email adress")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]

        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]

        public bool? WillAttend { get; set; }

    }
}