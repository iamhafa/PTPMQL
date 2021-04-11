using PTPMQL.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace PTPMQL.Controllers
{
    public class CheckAccountController : Controller
    {
        
        public ViewResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        //nhận dữ liệu từ client gửi lên
        public ActionResult Login(CheckAccount checkacc, string returnUrl)
        {
            //nếu vượt qua được validation ở checkaccount
            if (ModelState.IsValid)
            {
                if (checkacc.CheckUserName == "iamhafa" && checkacc.CheckPassword == "nothing")
                {
                    FormsAuthentication.SetAuthCookie(checkacc.CheckPassword, true);
                    return RedirectToLocal(returnUrl);
                }
            }
            return View(checkacc);
        }
        //hàm đăng xuất khỏi chương trình

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        //kiểm tra xem returnURL1 có thuộc hệ thống hay không
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}