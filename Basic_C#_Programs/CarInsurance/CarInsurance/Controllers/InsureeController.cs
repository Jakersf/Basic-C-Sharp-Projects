using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        public InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                
                db.Insurees.Add(insuree);
                
                Decimal Quote = 50m;
                //All of my logic for calculating the insuree quote will be below.
                if (insuree.DateOfBirth.Year <= 18) Quote += 100m;
                else if (insuree.DateOfBirth.Year >= 19 && insuree.DateOfBirth.Year <= 25) Quote += 50m;
                else Quote += 25m;

                if (insuree.CarYear < 2000) Quote += 25m;
                else if (insuree.CarYear > 2015) Quote += 25m;

                if (insuree.CarMake == "Porsche") Quote += 25m;
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera") Quote += 25m;

                if (insuree.SpeedingTickets >= 1)
                {
                    for (int c = 0; c < insuree.SpeedingTickets; c++)
                    {
                        Quote += 10m;
                    }
                }
                Decimal DUI = 1.25m;
                if (insuree.DUI == true) Quote = Quote * DUI;

                Decimal FullCoverage = 1.5m;
                if (insuree.CoverageType == true) Quote = Quote * FullCoverage;

                insuree.Quote = Quote;
                
                db.SaveChanges();
                return RedirectToAction("Index");
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
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                Decimal Quote = 50m;
                //All of my logic for calculating the insuree quote will be below.
                if (insuree.DateOfBirth.Year <= 18) Quote += 100m;
                else if (insuree.DateOfBirth.Year >= 19 || insuree.DateOfBirth.Year <= 25) Quote += 50m;
                else Quote += 25m;

                if (insuree.CarYear < 2000) Quote += 25m;
                else if (insuree.CarYear > 2015) Quote += 25m;

                if (insuree.CarMake == "Porsche") Quote += 25m;
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera") Quote += 25m;

                if (insuree.SpeedingTickets >= 1)
                {
                    for (int c = 0; c < insuree.SpeedingTickets; c++)
                    {
                        Quote += 10m;
                    }
                }
                Decimal DUI = 1.25m;
                if (insuree.DUI == true) Quote = Quote * DUI;

                Decimal FullCoverage = 1.5m;
                if (insuree.CoverageType == true) Quote = Quote * FullCoverage;

                insuree.Quote = Quote;
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

        private void GetQuote(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            Decimal Quote = 50m;
            //All of my logic for calculating the insuree quote will be below.
            if (insuree.DateOfBirth.Year <= 18) Quote += 100m; 
            else if (insuree.DateOfBirth.Year >= 19 && insuree.DateOfBirth.Year <= 25) Quote += 50m;
            else Quote += 25m;

            if (insuree.CarYear < 2000) Quote += 25m;
            else if (insuree.CarYear > 2015) Quote += 25m;

            if (insuree.CarMake == "Porsche") Quote += 25m;
            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera") Quote += 25m;

            if (insuree.SpeedingTickets >= 1)
            {
                for (int c = 0; c < insuree.SpeedingTickets; c++)
                {
                    Quote += 10m;
                }
            }
            Decimal DUI = 1.25m;
            if (insuree.DUI == true) Quote = Quote * DUI;

            Decimal FullCoverage = 1.5m;
            if (insuree.CoverageType == true) Quote = Quote * FullCoverage;

            insuree.Quote = Quote;
            db.SaveChanges();
            
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
            //List<Insuree> insuree = new List<Insuree>();
            return View(db.Insurees.ToList());
        }
    }
}
