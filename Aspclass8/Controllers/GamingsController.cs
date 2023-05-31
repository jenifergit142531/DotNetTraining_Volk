using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aspclass8;

namespace Aspclass8.Controllers
{
    public class GamingsController : Controller
    {
        private DemoEntities1 db = new DemoEntities1();

        // GET: gamings
        public ActionResult Index()
        {
            return View(db.gamings.ToList());
        }

        // GET: gamings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gaming gaming = db.gamings.Find(id);
            if (gaming == null)
            {
                return HttpNotFound();
            }
            return View(gaming);
        }

        // GET: gamings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: gamings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "gid,gname")] gaming gaming)
        {
            if (ModelState.IsValid)
            {
                db.gamings.Add(gaming);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gaming);
        }

        // GET: gamings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gaming gaming = db.gamings.Find(id);
            if (gaming == null)
            {
                return HttpNotFound();
            }
            return View(gaming);
        }

        // POST: gamings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "gid,gname")] gaming gaming)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gaming).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gaming);
        }

        // GET: gamings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gaming gaming = db.gamings.Find(id);
            if (gaming == null)
            {
                return HttpNotFound();
            }
            return View(gaming);
        }

        // POST: gamings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            gaming gaming = db.gamings.Find(id);
            db.gamings.Remove(gaming);
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
