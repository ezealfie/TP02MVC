using System.Diagnostics;
using System.Reflection.PortableExecutable;
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

    [HttpGet]
    public IActionResult GenerarSugerencia(SugeridorReceta datos)
    {
        ViewBag.plato = datos.DeterminarPlato();
        ViewBag.dificultad = datos.DeterminarDificultad();
        ViewBag.tiempo = datos.CalcularTiempo();
        ViewBag.datos = datos;
        return View("Resultado");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
