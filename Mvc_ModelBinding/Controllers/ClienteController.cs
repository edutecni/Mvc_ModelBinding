using Microsoft.AspNetCore.Mvc;
using Mvc_ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_ModelBinding.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cliente cliente)
        {
            if (cliente?.ClienteId == 0 || cliente?.Nome == null || cliente?.Email == null)
            {
                ViewBag.Erro = "Dados do cliente Inválido!";
                return View();
            }
            else
            {
                return View("ExibirDados", cliente);
            }
        }
    }
}
