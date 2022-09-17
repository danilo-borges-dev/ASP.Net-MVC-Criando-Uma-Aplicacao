using Microsoft.AspNetCore.Mvc;
using MinhaAplicacaoMVC_2.Models;
using System.Diagnostics;

namespace MinhaAplicacaoMVC_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id, string categoria)
        {
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