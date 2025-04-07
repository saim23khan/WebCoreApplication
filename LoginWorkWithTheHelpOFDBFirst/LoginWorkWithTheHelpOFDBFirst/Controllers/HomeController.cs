using LoginWorkWithTheHelpOFDBFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LoginWorkWithTheHelpOFDBFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly CreateDbforCodeContext context;

        public HomeController(CreateDbforCodeContext context)
        {
            this.context = context;
        }

        public IActionResult CreateUser()
        {
            if (HttpContext.Session.GetString("AddSessionForLogin") != null)
            {
                ViewBag.MySession = HttpContext.Session.GetString("AddSessionForLogin").ToString();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(User usertbl)
        {
            
            if (ModelState.IsValid)
            {
                await context.Users.AddAsync(usertbl);
                await context.SaveChangesAsync();
                TempData["SuccessMessage"] = "User created successfully!";
                return RedirectToAction("LoginPage", "Login");
            }
            return View();
        }

        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("AddSessionForLogin") != null)
            {
                ViewBag.MySession = HttpContext.Session.GetString("AddSessionForLogin").ToString();

            }
            else
            {
                return RedirectToAction("LoginPage", "Login");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            if (HttpContext.Session.GetString("AddSessionForLogin") != null)
            {
                ViewBag.MySession = HttpContext.Session.GetString("AddSessionForLogin").ToString();
            }
            else
            {
                return RedirectToAction("LoginPage", "Login");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
