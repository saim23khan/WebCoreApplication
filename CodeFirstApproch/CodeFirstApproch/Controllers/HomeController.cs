using CodeFirstApproch.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CodeFirstApproch.Controllers
{
    public class HomeController : Controller
    {


        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly StudentDBContext studentDB;
        public HomeController(StudentDBContext studentDB)
        {
            this.studentDB = studentDB;
        }

        public async Task<IActionResult> Index()
        {
            var stdData =await this.studentDB.Students.ToListAsync();
            return View(stdData);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student std)
        {
            if(ModelState.IsValid)
            {
              await  studentDB.Students.AddAsync(std);
              await  studentDB.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }

            return View();
        }

        public async Task <IActionResult> Details(int? id)
        {
            if(id == null || studentDB.Students == null)
            {
                return NotFound();
            }
            var stdData = await this.studentDB.Students.FirstOrDefaultAsync(x => x.ID == id);
            if (stdData == null) 
            {
                return NotFound();
            }
            return View(stdData);
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
