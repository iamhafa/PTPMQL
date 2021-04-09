using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTPMQL.Models;

namespace PTPMQL.Controllers
{
    public class KhachHangsController : Controller
    {
        // GET: KhachHangs
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(KhachHang kh)
        {
            return View();
        }
    }
}