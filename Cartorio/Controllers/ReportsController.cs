using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Cartorio.Data; // Certifique-se de que o namespace correto para o modelo Nascimento está incluído

namespace Cartorio.Controllers
{
    public class ReportsController : Controller
    {
        private readonly AppDbContext _context;

        public ReportsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ReportsController
        public ActionResult Reports()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetNascimentoReport(DateTime startDate, DateTime endDate, string reportType)
        {
            // Filtrar os registros de nascimento no intervalo de datas
            var nacimentos = _context.Nascimentos
                .Where(n => n.DataDeNascimento >= startDate && n.DataDeNascimento <= endDate)
                .ToList();

            if (reportType.Equals("HTML", StringComparison.OrdinalIgnoreCase))
            {
                // Passar as datas para a view
                ViewBag.StartDate = startDate;
                ViewBag.EndDate = endDate;

                // Retornar uma view com os dados
                return View("NascimentoReport", nacimentos);
            }
            else if (reportType.Equals("XML", StringComparison.OrdinalIgnoreCase))
            {
                // Gerar o arquivo XML
                var xml = new XDocument(
                    new XElement("Nascimentos",
                        nacimentos.Select(n => new XElement("Nascimento",
                            new XElement("Id", n.Id),
                            new XElement("Nome", n.NomeDoRegistrado),
                            new XElement("DataNascimento", n.DataDeNascimento.ToString("yyyy-MM-dd")),
                            new XElement("NomeMae", n.NomeDoPai),
                            new XElement("NomePai", n.NomeDaMae),
                            new XElement("DataRegistro", n.DataDoRegistro.ToString("yyyy-MM-dd")),
                            new XElement("CpfMae", n.CpfDaMae),
                            new XElement("CpfPai", n.CpfDoPai),
                            new XElement("DataNascimentoMae", n.DataDeNascimentoDaMae?.ToString("yyyy-MM-dd")),
                            new XElement("DataNascimentoPai", n.DataDeNascimentoDoPai?.ToString("yyyy-MM-dd"))
                        ))
                    )
                );

                var xmlBytes = Encoding.UTF8.GetBytes(xml.ToString());
                return File(xmlBytes, "application/xml", "nascimentos.xml");


            }

            return BadRequest("Tipo de relatório inválido.");
        }
    }
}
