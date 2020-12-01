//using Exercise1.Models;
using Exercise1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercise1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {
            string name = "JKTVR19HomeController";
            ViewBag.Hello = "Hi, " + name;

            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "First" : "Second";

            return View();
        }
        [HttpGet]//показать форму
        public ViewResult ContactForm()
        {
            return View();
        }

        [HttpPost]//прочитать данные из формы
        public ViewResult ContactForm(ContactResponce contactResponce)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", contactResponce);
            }
            else
            {
                return View();
            }
        }

    }
}