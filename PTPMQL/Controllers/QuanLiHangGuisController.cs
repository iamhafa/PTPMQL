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
    public class QuanLiHangGuisController : Controller
    {
        private DemoDbConText db = new DemoDbConText();

        // GET: QuanLiHangGuis
        public ActionResult Index()
        {
            return View(db.QuanLiHangGuis.ToList());
        }

        // GET: QuanLiHangGuis/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanLiHangGui quanLiHangGui = db.QuanLiHangGuis.Find(id);
            if (quanLiHangGui == null)
            {
                return HttpNotFound();
            }
            return View(quanLiHangGui);
        }

        // GET: QuanLiHangGuis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuanLiHangGuis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHangGui,NgayGioGuiHang,TrongLuongHangGui,XacNhanHopLe")] QuanLiHangGui quanLiHangGui)
        {
            if (ModelState.IsValid)
            {
                db.QuanLiHangGuis.Add(quanLiHangGui);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quanLiHangGui);
        }

        // GET: QuanLiHangGuis/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanLiHangGui quanLiHangGui = db.QuanLiHangGuis.Find(id);
            if (quanLiHangGui == null)
            {
                return HttpNotFound();
            }
            return View(quanLiHangGui);
        }

        // POST: QuanLiHangGuis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHangGui,NgayGioGuiHang,TrongLuongHangGui,XacNhanHopLe")] QuanLiHangGui quanLiHangGui)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quanLiHangGui).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quanLiHangGui);
        }

        // GET: QuanLiHangGuis/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanLiHangGui quanLiHangGui = db.QuanLiHangGuis.Find(id);
            if (quanLiHangGui == null)
            {
                return HttpNotFound();
            }
            return View(quanLiHangGui);
        }

        // POST: QuanLiHangGuis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            QuanLiHangGui quanLiHangGui = db.QuanLiHangGuis.Find(id);
            db.QuanLiHangGuis.Remove(quanLiHangGui);
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
