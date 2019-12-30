using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc.Application.Models;

namespace Mvc.Application.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Filme filme)
        {
            if (ModelState.IsValid)
            {
                //verificar depois 
            }
            return View(filme);
        }
    }
}