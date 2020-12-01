using Praktika1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Praktika1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string name = "world";
            ViewBag.Hello = "tere, " + name;

            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Tere hommikust" : "Tere päevast";

            return View();
        }
        [HttpGet]//показать форму
        public ViewResult RegisterForm()
        {
            return View();
        }

        [HttpPost]//прочитать данные из формы
        public ViewResult RegisterForm(GuestResponce guestResponce)
        {
            if(ModelState.IsValid)
            {
                return View("Thanks", guestResponce);
            }
            else
            {
                return View();
            }
        }

    }
}