using System.Web.Mvc;
using PTPMQL.Models;

namespace PTPMQL.Controllers
{
    public class AccountsController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Account acc)
        {
            return View(acc);
        }
    }
}