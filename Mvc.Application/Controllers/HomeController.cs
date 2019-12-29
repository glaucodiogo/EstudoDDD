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

        [Route("erro-encontrado")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
