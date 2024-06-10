using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QUANTUMWEB.Models;
using System.Diagnostics;

namespace QUANTUMWEB.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private WebDbContext _context;
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(WebDbContext context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }

        
       
        public IActionResult UserProfile()
         {
             return View("UserProfile");
         }
        public IActionResult Musteriler()
        {
            return View("Musteriler");
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
