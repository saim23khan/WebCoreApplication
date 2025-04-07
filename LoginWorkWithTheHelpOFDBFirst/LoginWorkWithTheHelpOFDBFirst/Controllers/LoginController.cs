using LoginWorkWithTheHelpOFDBFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace LoginWorkWithTheHelpOFDBFirst.Controllers
{
    public class LoginController : Controller
    {
        private readonly CreateDbforCodeContext context;

        public LoginController(CreateDbforCodeContext context)
        {
            this.context = context;
        }
        public IActionResult LoginPage()
        {
            if (HttpContext.Session.GetString("AddSessionForLogin") != null)
            {
                ViewBag.MySession = HttpContext.Session.GetString("AddSessionForLogin").ToString();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult LoginPage(User tbluser)
        {
            var getuserfromlogin = context.Users.Where(x => x.UserName == tbluser.UserName && x.Password == tbluser.Password).FirstOrDefault();

            if (getuserfromlogin != null)
            {
                HttpContext.Session.SetString("AddSessionForLogin", getuserfromlogin.UserName);
                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.Message = "Login Failed";
            }
            return View();
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("AddSessionForLogin") != null)
            {
                HttpContext.Session.Remove("AddSessionForLogin");
                return RedirectToAction("LoginPage","Login");
            }
            return View();
        }

        public IActionResult CreateUser()
        {
            return View();
        }
    }
}
