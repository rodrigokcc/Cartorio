using System.Diagnostics;
using Cartorio.Data;
using Cartorio.Interfaces;
using Cartorio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cartorio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICasamentoRepository _casamentoRepository;
        private readonly IObitoRepository _obitoRepository;
        private readonly INascimentoRepository _nascimentoRepository;
        public HomeController(ICasamentoRepository casamentoRepository, IObitoRepository obitoRepository, INascimentoRepository nascimentoRepository)
        {
            _casamentoRepository = casamentoRepository;
            _obitoRepository = obitoRepository;
            _nascimentoRepository = nascimentoRepository;
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
                _obitoRepository.Add(obito); // Adiciona o registro ao banco
                return RedirectToAction("Index"); // Redireciona para a página inicial ou outra página
            }

            return View(obito); // Retorna a mesma view com os erros de validação
        }

        [HttpPost]
        public IActionResult AddCasamento(Casamento casamento)
        {
            if (ModelState.IsValid)
            {
                _casamentoRepository.Add(casamento); // Adiciona o registro ao banco
                return RedirectToAction("Index"); // Redireciona para a página inicial ou outra página
            }

            return View(casamento); // Retorna a mesma view com os erros de validação
        }

        [HttpPost]
        public IActionResult AddNascimento(Nascimento nascimento)
        {
            if (ModelState.IsValid)
            {
                _nascimentoRepository.Add(nascimento); // Adiciona o registro ao banco
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
