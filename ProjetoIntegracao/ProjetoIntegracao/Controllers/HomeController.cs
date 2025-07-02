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
            // Por enquanto só exibe os dados no console (simulação)
            Console.WriteLine($"Usuário: {usuario}, Senha: {senha}");

            // Depois você fará a validação real
            return RedirectToAction("Index", "Home");
        }
    }
}
