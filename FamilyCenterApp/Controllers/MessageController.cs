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
    public class MessageController : Controller
    {
        private FamilyCenterAppContext db = new FamilyCenterAppContext();

        // GET: Message
        public ActionResult Index()
        {
            return View(db.MessageModels.ToList());
        }

        // GET: Message/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MessageModel messageModel = db.MessageModels.Find(id);
            if (messageModel == null)
            {
                return HttpNotFound();
            }
            return View(messageModel);
        }

        // GET: Message/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Message/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MessageText,TimeStamp,UserId")] MessageModel messageModel)
        {
            if (ModelState.IsValid)
            {
                db.MessageModels.Add(messageModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(messageModel);
        }

        // GET: Message/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MessageModel messageModel = db.MessageModels.Find(id);
            if (messageModel == null)
            {
                return HttpNotFound();
            }
            return View(messageModel);
        }

        // POST: Message/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MessageText,TimeStamp,UserId")] MessageModel messageModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(messageModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(messageModel);
        }

        // GET: Message/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MessageModel messageModel = db.MessageModels.Find(id);
            if (messageModel == null)
            {
                return HttpNotFound();
            }
            return View(messageModel);
        }

        // POST: Message/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MessageModel messageModel = db.MessageModels.Find(id);
            db.MessageModels.Remove(messageModel);
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
