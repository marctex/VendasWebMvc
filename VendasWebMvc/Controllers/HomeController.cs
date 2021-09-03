using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VendasWebMvc.Models.ViewModels;

namespace VendasWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Vendas Web MVC do curso C#";
            ViewData["Professor"] = "Nelio";
            ViewData["Aluno"] = "Marcelo Teixeira Martins";
            ViewData["email"] = "marcelo.t.martins@hotmail.com";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
