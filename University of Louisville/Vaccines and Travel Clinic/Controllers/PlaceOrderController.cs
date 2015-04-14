using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vaccines_and_Travel_Clinic.DAL;
using Vaccines_and_Travel_Clinic.Models;

namespace Vaccines_and_Travel_Clinic.Controllers
{
    public class PlaceOrderController : Controller
    {
        private ClinicContext db = new ClinicContext();
        // GET: PlaceOrder
        public ActionResult Complete()
        {
            return View("Complete");
        }

        public ActionResult Create([Bind(Include = "ID,Name,Description,Count,Price")] Item item)
        {


            if (ModelState.IsValid)
            {
                db.Items.Add(item);
                db.SaveChanges();
                return RedirectToAction("Complete");
            }

            return View("_ItemPartialView");
        }
    }
}