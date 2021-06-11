using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using PTPMQL.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PTPMQL.Controllers
{
    public class AccountController : Controller
    {
        Encryption encry = new Encryption();
        DemoDbConText db = new DemoDbConText();
        

        //CAPTCHA bảo mật cao
        [HttpGet]
        public ActionResult reCaptcha()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateGoogleCaptcha]
        public ActionResult reCaptcha(string title)
        {
            // If we are here, Captcha is validated.  
            return View();
        }

         
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]

        public ActionResult Register(Account acc)
        {
            if (ModelState.IsValid)
            {
                //mã hóa mật khẩu trước khi lưu vào database
                acc.Password = encry.PasswordEncryption(acc.Password);
                db.Accounts.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Login", "Account");
            }
            return View(acc);
        }
        [HttpGet]

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(Account acc)
        {
            if (ModelState.IsValid)
            {
                string encryptionpass = encry.PasswordEncryption(acc.Password);
                var model = db.Accounts.Where(m => m.UserName == acc.UserName && m.Password == encryptionpass).ToList().Count();
                //Thông tin đăng nhập chính xác
                if (model == 1)
                {
                    FormsAuthentication.SetAuthCookie(acc.UserName, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Thông tin đăng nhập không chính xác");
                }
            }
            return View(acc);
        }
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        
    }
}