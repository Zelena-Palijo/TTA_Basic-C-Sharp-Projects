using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance2.Models;

namespace CarInsurance2.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        //calculate car insurance quote
        //public decimal QuoteDetails(Insuree insuree)
        //{
            
        //}

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                decimal quote = 50; //start with base quote of $50/month
                var today = DateTime.Today; //to calculate age
                var age = today.Year - insuree.DateOfBirth.Year;

                //quote changes based on AGE
                //if user is 18 or under, add $100
                if (age <= 18)
                {
                    quote += 100;
                }
                //if user is 19-25, add $50
                if (age > 18 && age <= 25)
                {
                    quote += 50;
                }
                //if user is 26 or older, add $25
                if (age > 25)
                {
                    quote += 25;
                }

                //quote changes based on CAR DETAILS
                // IF CAR'S YEAR BEFORE 2000, add $25
                if (insuree.CarYear < 2000)
                {
                    quote += 25;
                }
                //if car's year is after 2015, add $25
                if (insuree.CarYear > 2015)
                {
                    quote += 25;
                }
                //if car make is porsche add $25
                if (insuree.CarMake == "Porsche")
                {
                    if (insuree.CarModel == "911 Carrerra")
                    {
                        quote += 25; // if also 911 carrerra, add additional $25
                    }
                    quote += 25;
                }

                //quote changes based on speeding tickets
                //add $10 for each speeding ticket
                for (int i = 0; i < insuree.SpeedingTickets; i++)
                {
                    quote += 10;
                }

                //quote changes based on DUI
                //if user ever had DUI then add 25% to the total
                if (insuree.DUI == true)
                {
                    quote = quote * 1.25m; //need to change to decimal?
                }

                // quote changes based on coverage
                // if full coverage add 50% to total
                if (insuree.CoverageType == true)
                {
                    quote = quote * 1.50m;
                }

                insuree.Quote = quote;
                

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index", quote);
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }
    }
}
