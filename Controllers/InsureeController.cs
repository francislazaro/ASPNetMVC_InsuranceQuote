using System;
using System.Linq;
using System.Web.Mvc;
using ASPNetMVC_InsuranceQuote.Models;

namespace ASPNetMVC_InsuranceQuote.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        public ActionResult Create(Insuree insuree)
        {
            decimal quote = 50;

            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < insuree.DateOfBirth.DayOfYear)
            {
                age--;
            }

            if (age <= 18)
                quote += 100;
            else if (age >= 19 && age <= 25)
                quote += 50;
            else
                quote += 25;

            if (insuree.CarYear < 2000)
                quote += 25;

            if (insuree.CarYear > 2015)
                quote += 25;

            if (!string.IsNullOrEmpty(insuree.CarMake) && insuree.CarMake.ToLower() == "porsche")
            {
                quote += 25;

                if (!string.IsNullOrEmpty(insuree.CarModel) && insuree.CarModel.ToLower() == "911 carrera")
                    quote += 25;
            }

            quote += insuree.SpeedingTickets * 10;

            if (insuree.DUI)
                quote *= 1.25m;

            if (!string.IsNullOrEmpty(insuree.CoverageType) && insuree.CoverageType.ToLower() == "full")
                quote *= 1.5m;

            insuree.Quote = quote;

            db.Insurees.Add(insuree);
            db.SaveChanges();

            return RedirectToAction("Admin");
        }

        public ActionResult Admin()
        {
            var insurees = db.Insurees.ToList();
            return View(insurees);
        }
    }
}