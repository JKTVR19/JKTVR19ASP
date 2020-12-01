using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercise1.Models
{
    public class ContactResponce
    {
        [Required(ErrorMessage = "Please enter you name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email adress")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Please enter a valid email adress")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your your message")]

        public string Message { get; set; }
        [Required(ErrorMessage = "Please repeat once more")]

        public bool? WillAttend { get; set; }

    }
}