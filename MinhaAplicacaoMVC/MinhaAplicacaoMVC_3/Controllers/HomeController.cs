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
            var filme = new Filme()
            {
                Titulo = "Oi",
                DataDeLancamento = DateTime.Now,
                Genero = null,
                Avaliacao = 10,
                Valor = 20000,
            };

            return View();
        }

        [Route("privacidade")]
        [Route("policita-de-privacidade")]
        public IActionResult Privacy(Filme filme)
        {
            if (ModelState.IsValid)
            {

            }
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