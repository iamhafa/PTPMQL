using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PTPMQL.Models;

namespace PTPMQL.Controllers
{
    public class QuanLiChuyenBaysController : Controller
    {
        private DemoDbConText db = new DemoDbConText();

        // GET: QuanLiChuyenBays
        public ActionResult Index()
        {
            return View(db.QuanLiChuyenBays.ToList());
        }

        // GET: QuanLiChuyenBays/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanLiChuyenBay quanLiChuyenBay = db.QuanLiChuyenBays.Find(id);
            if (quanLiChuyenBay == null)
            {
                return HttpNotFound();
            }
            return View(quanLiChuyenBay);
        }

        // GET: QuanLiChuyenBays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuanLiChuyenBays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaChuyenBay,DiemKhoiHanh,DiemDen,ThoiGianBay,ChoNgoi,Address")] QuanLiChuyenBay quanLiChuyenBay)
        {
            if (ModelState.IsValid)
            {
                db.QuanLiChuyenBays.Add(quanLiChuyenBay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quanLiChuyenBay);
        }

        // GET: QuanLiChuyenBays/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanLiChuyenBay quanLiChuyenBay = db.QuanLiChuyenBays.Find(id);
            if (quanLiChuyenBay == null)
            {
                return HttpNotFound();
            }
            return View(quanLiChuyenBay);
        }

        // POST: QuanLiChuyenBays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaChuyenBay,DiemKhoiHanh,DiemDen,ThoiGianBay,ChoNgoi,Address")] QuanLiChuyenBay quanLiChuyenBay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quanLiChuyenBay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quanLiChuyenBay);
        }

        // GET: QuanLiChuyenBays/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanLiChuyenBay quanLiChuyenBay = db.QuanLiChuyenBays.Find(id);
            if (quanLiChuyenBay == null)
            {
                return HttpNotFound();
            }
            return View(quanLiChuyenBay);
        }

        // POST: QuanLiChuyenBays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            QuanLiChuyenBay quanLiChuyenBay = db.QuanLiChuyenBays.Find(id);
            db.QuanLiChuyenBays.Remove(quanLiChuyenBay);
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
