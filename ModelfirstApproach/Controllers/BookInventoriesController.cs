using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ModelfirstApproach;

namespace ModelfirstApproach.Controllers
{
    public class BookInventoriesController : Controller
    {
        private Model1Container db = new Model1Container();

        // GET: BookInventories
        public ActionResult Index()
        {
            var bookInventories = db.BookInventories.Include(b => b.Book);
            return View(bookInventories.ToList());
        }

        // GET: BookInventories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookInventory bookInventory = db.BookInventories.Find(id);
            if (bookInventory == null)
            {
                return HttpNotFound();
            }
            return View(bookInventory);
        }

        // GET: BookInventories/Create
        public ActionResult Create()
        {
            ViewBag.BookId = new SelectList(db.Books, "Id", "Name");
            return View();
        }

        // POST: BookInventories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Price,Quantity,BookId")] BookInventory bookInventory)
        {
            if (ModelState.IsValid)
            {
                db.BookInventories.Add(bookInventory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BookId = new SelectList(db.Books, "Id", "Name", bookInventory.BookId);
            return View(bookInventory);
        }

        // GET: BookInventories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookInventory bookInventory = db.BookInventories.Find(id);
            if (bookInventory == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookId = new SelectList(db.Books, "Id", "Name", bookInventory.BookId);
            return View(bookInventory);
        }

        // POST: BookInventories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Price,Quantity,BookId")] BookInventory bookInventory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookInventory).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BookId = new SelectList(db.Books, "Id", "Name", bookInventory.BookId);
            return View(bookInventory);
        }

        // GET: BookInventories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookInventory bookInventory = db.BookInventories.Find(id);
            if (bookInventory == null)
            {
                return HttpNotFound();
            }
            return View(bookInventory);
        }

        // POST: BookInventories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookInventory bookInventory = db.BookInventories.Find(id);
            db.BookInventories.Remove(bookInventory);
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
