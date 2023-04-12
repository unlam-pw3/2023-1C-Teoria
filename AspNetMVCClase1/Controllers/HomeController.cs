using AspNetMVCClase1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetMVCClase1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Saludo()
        {
            return View();
        }
            
        public string Saludo2()
        {
            return "Hola Clase";
        }

        //[Route("Home/Inicio/{id?}/{month?}/{year?}")]
        public IActionResult Inicio(int id, int month, int year)
        {
            return View("Index");
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