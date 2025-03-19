using LoginWorkWithTheHelpOFDBFirst.Models;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        
        public IActionResult CreateUser()
        {
            return View();
        }
    }
}
