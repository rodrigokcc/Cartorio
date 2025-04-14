using System.Diagnostics;
using Cartorio.Data;
using Cartorio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cartorio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context; // Contexto do banco de dados

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Nascimento()
        {
            return View();
        }

        public IActionResult Casamento()
        {
            return View();
        }

        public IActionResult Obito()
        {
            return View();
        }

        public IActionResult Relatorio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddObito(Obito obito)
        {
            if (ModelState.IsValid)
            {
                _context.Obitos.Add(obito); // Adiciona o registro ao banco
                _context.SaveChanges(); // Salva as alterações
                return RedirectToAction("Index"); // Redireciona para a página inicial ou outra página
            }

            return View(obito); // Retorna a mesma view com os erros de validação
        }

        [HttpPost]
        public IActionResult AddCasamento(Casamento casamento)
        {
            if (ModelState.IsValid)
            {
                _context.Casamentos.Add(casamento); // Adiciona o registro ao banco
                _context.SaveChanges(); // Salva as alterações
                return RedirectToAction("Index"); // Redireciona para a página inicial ou outra página
            }

            return View(casamento); // Retorna a mesma view com os erros de validação
        }

        [HttpPost]
        public IActionResult AddNascimento(Nascimento nascimento)
        {
            if (ModelState.IsValid)
            {
                _context.Nascimentos.Add(nascimento); // Adiciona o registro ao banco
                _context.SaveChanges(); // Salva as alterações
                return RedirectToAction("Index"); // Redireciona para a página inicial ou outra página
            }

            return View(nascimento); // Retorna a mesma view com os erros de validação
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
