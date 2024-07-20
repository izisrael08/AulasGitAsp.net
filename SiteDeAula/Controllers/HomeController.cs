using Microsoft.AspNetCore.Mvc;
using SiteDeAula.Models;
using System.Diagnostics;

namespace SiteDeAula.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //preciso criar uma instancia para poder pegar os dados da home model
            HomeModel home = new HomeModel();

            home.Nome = "Israel Guedes";
            home.Email = "israelguedes008@gmail.com";
            Console.WriteLine("Teste_git 01, Teste_git 02, Teste_git 03");
            //teste teste
            return View(home);
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
