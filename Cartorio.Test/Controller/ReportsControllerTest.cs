using Cartorio.Controllers;
using Cartorio.Interfaces;
using Cartorio.Models;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Text;
namespace Cartorio.Test;

[TestFixture]
public class ReportsControllerTest
{
    private INascimentoRepository _nascimentoRepository;
    private ReportsController _controller;

    [SetUp]
    public void Setup()
    {
        // Dependencies
        _nascimentoRepository = A.Fake<INascimentoRepository>();
        _controller = new ReportsController(_nascimentoRepository);
    }

    [TearDown]
    public void TearDown()
    {
        // Dispose the controller
        _controller.Dispose();
    }

    [Test]
    public async Task GetNascimentoReport_ShouldReturnHtmlView_WhenReportTypeIsHtml()
    {
        // Arrange
        var startDate = new DateTime(2025, 1, 1);
        var endDate = new DateTime(2025, 12, 31);
        var reportType = "HTML";
        var nascimentos = new List<Nascimento>
        {
            new Nascimento
            {
                Id = 1,
                NomeDoRegistrado = "John Doe",
                DataDeNascimento = new DateTime(2025, 5, 1),
                DataDoRegistro = new DateTime(2025, 5, 2)
            }
        };

        A.CallTo(() => _nascimentoRepository.GetByDateRange(startDate, endDate))
            .Returns(Task.FromResult((IEnumerable<Nascimento>)nascimentos));

        // Act
        var result = await _controller.GetNascimentoReport(startDate, endDate, reportType);

        // Assert
        var viewResult = result as ViewResult;
        viewResult.Should().NotBeNull();
        viewResult!.ViewName.Should().Be("NascimentoReport");
        viewResult.Model.Should().BeEquivalentTo(nascimentos);
    }

    [Test]
    public async Task GetNascimentoReport_ShouldReturnXmlFile_WhenReportTypeIsXml()
    {
        // Arrange
        var startDate = new DateTime(2025, 1, 1);
        var endDate = new DateTime(2025, 12, 31);
        var reportType = "XML";
        var nascimentos = new List<Nascimento>
        {
            new Nascimento
            {
                Id = 1,
                NomeDoRegistrado = "John Doe",
                DataDeNascimento = new DateTime(2025, 5, 1),
                DataDoRegistro = new DateTime(2025, 5, 2)
            }
        };

        A.CallTo(() => _nascimentoRepository.GetByDateRange(startDate, endDate))
            .Returns(Task.FromResult((IEnumerable<Nascimento>)nascimentos));

        // Act
        var result = await _controller.GetNascimentoReport(startDate, endDate, reportType);

        // Assert
        var fileResult = result as FileContentResult;
        fileResult.Should().NotBeNull();
        fileResult!.ContentType.Should().Be("application/xml");
        fileResult.FileDownloadName.Should().Be("nascimentos.xml");

        var xmlContent = Encoding.UTF8.GetString(fileResult.FileContents);
        xmlContent.Should().Contain("<Nascimentos>");
        xmlContent.Should().Contain("<Nascimento>");
        xmlContent.Should().Contain("<Id>1</Id>");
        xmlContent.Should().Contain("<Nome>John Doe</Nome>");
    }

    [Test]
    public async Task GetNascimentoReport_ShouldReturnBadRequest_WhenReportTypeIsInvalid()
    {
        // Arrange
        var startDate = new DateTime(2025, 1, 1);
        var endDate = new DateTime(2025, 12, 31);
        var reportType = "INVALID";

        // Act
        var result = await _controller.GetNascimentoReport(startDate, endDate, reportType);

        // Assert
        var badRequestResult = result as BadRequestObjectResult;
        badRequestResult.Should().NotBeNull();
        badRequestResult!.Value.Should().Be("Tipo de relatório inválido.");
    }
}
