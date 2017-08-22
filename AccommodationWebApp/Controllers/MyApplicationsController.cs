using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AccommodationWebApp.Models;

namespace AccommodationWebApp.Controllers
{
    public class MyApplicationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MyApplications
        public ActionResult Index()
        {
            return View(db.MyApplications.ToList());
        }

        // GET: MyApplications/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking myBooking = db.MyApplications.Find(id);
            if (myBooking == null)
            {
                return HttpNotFound();
            }
            return View(myBooking);
        }

        // GET: MyApplications/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyApplications/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ApplicationReferenceNo,StudentId,DateOfApplication,RoomType,AdmountDue")] Booking myApplication)
        {
            if (ModelState.IsValid)
            {
                db.MyApplications.Add(myApplication);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(myApplication);
        }

        // GET: MyApplications/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking myApplication = db.MyApplications.Find(id);
            if (myApplication == null)
            {
                return HttpNotFound();
            }
            return View(myApplication);
        }

        // POST: MyApplications/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ApplicationReferenceNo,StudentId,DateOfApplication,RoomType,AdmountDue")] Booking myApplication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myApplication).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myApplication);
        }

        // GET: MyApplications/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking myApplication = db.MyApplications.Find(id);
            if (myApplication == null)
            {
                return HttpNotFound();
            }
            return View(myApplication);
        }

        // POST: MyApplications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Booking myApplication = db.MyApplications.Find(id);
            db.MyApplications.Remove(myApplication);
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
    }
}
