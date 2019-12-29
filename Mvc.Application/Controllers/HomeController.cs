using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc.Application.Models;

namespace Mvc.Application.Controllers
{
    //Rotas inteligentes
  
    [Route("gestao")]
    public class HomeController : Controller
    {
        //Rotas com parametros tipados, excelente para aumentar segurança,campos obrigatorios
        [Route("")]
        [Route("inicial")]
        //[Route("pagina-inicial/{id:int}/{}/categoria:guid")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult BaixarPdf()
        {
            //realiza a leitura em bytes e converte a saida para pdf no navegador;
            var fileBytes = System.IO.File.ReadAllBytes(@"F:/arquivo.pdf");
            var fileName = "arquivo.pdf";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Pdf, fileName);
        }

        public IActionResult RetornarQualquerCoisa()
        {
            return Content("Apenas texto");
        }

        public IActionResult RetornarJson()
        {
            return Json("{'nome':'José'}");
        }

        [Route("erro-encontrado")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
