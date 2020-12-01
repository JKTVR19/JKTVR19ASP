﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PraktikaHotelsMVC.Models;

namespace PraktikaHotelsMVC.Controllers
{
    public class CitiesController : Controller
    {
        // GET: Cities
        public ActionResult Index()         
        {
            ViewBag.Cities = CitiesCollection.listCities;
            return View();
        }

        public ActionResult Details(int id=0)
        {
            ViewBag.Cities = CitiesCollection.listCities;
            if (id != 0)
            {
                ViewBag.HotelId = id;
                return View();
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Cities()
        {
            ViewBag.Cities = CitiesCollection.listCities;
                      return View();
        }

        public ActionResult Hotels(int id = 0)
        {
            ViewBag.Cities = CitiesCollection.listCities;
            if (id != 0)
            {
                ViewBag.CityId = id;
                return View();
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}