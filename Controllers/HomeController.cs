using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP02.Models;
using TP02MVC.Models;

namespace TP02.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GenerarSugerencia(SugeridorReceta datos)
    {
        ViewBag.plato = datos.DeterminarPlato();
        ViewBag.dificultad = datos.DeterminarDificultad();
        ViewBag.tiempo = datos.CalcularTiempo();
        return View("Resultado");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
