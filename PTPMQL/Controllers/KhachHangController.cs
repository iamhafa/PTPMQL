using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTPMQL.Models;

namespace PTPMQL.Controllers
{
    public class KhachHangController : Controller
    {
        //khai bao doi tuong ket noi toi database
        DemoDbConText db = new DemoDbConText();
        // GET: KhachHang
        public ViewResult Index()
        {
            //lay toan bo du lieu trong bang KhachHang
            //tra ve dang list roi hien thi len view
            return View(db.KhachHangs.ToList());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(KhachHang kh)
        {
            if (ModelState.IsValid)
            {
                db.KhachHangs.Add(kh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kh);
        }
    }
}