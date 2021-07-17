using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetMvcDocker.Dominio.Models;
using AspNetMvcDocker.Dominio.Interface;

namespace AspNetMvcDocker.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    public IRepository repositorio;

    public HomeController(IRepository repositorio, ILogger<HomeController> logger)
    {
      this.repositorio = repositorio;
      _logger = logger;
    }

    public IActionResult Index()
        => View(repositorio.Produtos);

    public IActionResult Privacy()
        => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
        => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
