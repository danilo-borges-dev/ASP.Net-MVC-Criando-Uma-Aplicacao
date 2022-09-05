using Microsoft.AspNetCore.Mvc;
using MinhaAplicacaoMVC.Models;
using System.Diagnostics;

namespace MinhaAplicacaoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string categoria, string id)
        {
            return View();
        }
         
        public IActionResult Privacy()
        {
            ContatoModel contato = new();

            contato.Nome = "Danilo Silva";
            contato.Email = "danilosilva@gmail.com";

            return View(contato);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}