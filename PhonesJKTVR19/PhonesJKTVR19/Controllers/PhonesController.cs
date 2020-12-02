using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PhonesJKTVR19.Models;
using PagedList;

namespace PhonesJKTVR19.Controllers
{
    public class PhonesController : Controller
    {
        private PhonesEntities db = new PhonesEntities();

        // GET: Phones
        public ActionResult Index(int? page)
        {
            //var phones = db.Phones.Include(p => p.Company).OrderBy(p => p.Name); ;
            // return View(phones.ToList());
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            var phones = db.Phones.Include(p => p.Company).OrderBy(p => p.Name).ToList();
            return View(phones.ToPagedList(pageNumber, pageSize));

        }

        // GET: Phones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Phone phone = db.Phones.Include(p => p.Company).FirstOrDefault(t => t.Id == id);
            if (phone == null)
            {
                return HttpNotFound();
            }
            return View(phone);
        }
        //-------------------------------
        [HttpPost]
        public ActionResult PhoneSearch(string PhoneName)
        {
            // List phones sort by search condition, sort by price and descending
            var allPhones = db.Phones.Include(a => a.Company).Where(b => b.Name.Contains(PhoneName)).OrderByDescending(t => t.Price).ToList();

            if(allPhones.Count <= 0)
            {
                return HttpNotFound();
            }
            return PartialView(allPhones);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
