using Microsoft.AspNetCore.Mvc;
using MinhaAplicacaoMVC_3.Models;
using System.Diagnostics;

namespace MinhaAplicacaoMVC_3.Controllers
{
    [Route("")]
    [Route("gestao-clientes/")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("pagina-inicial/{id:int}/{categoria?}")]
        public IActionResult Index(string id, Guid categoria)
        {
            return View();
        }

        [Route("privacidade")]
        [Route("policita-de-privacidade")]
        public IActionResult Privacy()
        {
            // return Json("{'nome':'Danilo'}");
            // var fileBytes = System.IO.File.ReadAllBytes(@"c:\arquivo.txt");
            // var fileName = "novo_arquivo.txt";
            // return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
            // return Content("Realizando um teste de comentário.");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}