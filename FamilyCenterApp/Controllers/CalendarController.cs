using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FamilyCenterApp.Models;

namespace FamilyCenterApp.Controllers
{
    public class CalendarController : Controller
    {
        private FamilyCenterAppContext db = new FamilyCenterAppContext();

        // GET: Calendar
        public ActionResult Index()
        {
            return View(db.CalendarModels.ToList());
        }

        // GET: Calendar/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalendarModel calendarModel = db.CalendarModels.Find(id);
            if (calendarModel == null)
            {
                return HttpNotFound();
            }
            return View(calendarModel);
        }

        // GET: Calendar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calendar/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EventText,TimeStamp,EventDate,UserId")] CalendarModel calendarModel)
        {
            if (ModelState.IsValid)
            {
                db.CalendarModels.Add(calendarModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(calendarModel);
        }

        // GET: Calendar/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalendarModel calendarModel = db.CalendarModels.Find(id);
            if (calendarModel == null)
            {
                return HttpNotFound();
            }
            return View(calendarModel);
        }

        // POST: Calendar/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EventText,TimeStamp,EventDate,UserId")] CalendarModel calendarModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calendarModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calendarModel);
        }

        // GET: Calendar/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalendarModel calendarModel = db.CalendarModels.Find(id);
            if (calendarModel == null)
            {
                return HttpNotFound();
            }
            return View(calendarModel);
        }

        // POST: Calendar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CalendarModel calendarModel = db.CalendarModels.Find(id);
            db.CalendarModels.Remove(calendarModel);
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
