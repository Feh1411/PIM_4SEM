using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoIntegracao.Models;

namespace ProjetoIntegracao.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string usuario, string senha)
        {
            // Por enquanto s� exibe os dados no console (simula��o)
            Console.WriteLine($"Usu�rio: {usuario}, Senha: {senha}");

            // Depois voc� far� a valida��o real
            return RedirectToAction("Index", "Home");
        }
    }
}
