using LoginWorkWithTheHelpOFDBFirst.Models;
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
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(User usertbl)
        {
            if (ModelState.IsValid)
            {
                await context.Users.AddAsync(usertbl);
                await context.SaveChangesAsync();
                return RedirectToAction("Privacy", "Home");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
