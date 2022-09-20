using System.Diagnostics;
using Calculadora.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers;

public class FuncionalidadesController : Controller
{
     private readonly ILogger<FuncionalidadesController> _logger;
         public FuncionalidadesController(ILogger<FuncionalidadesController> logger)
    {
        _logger = logger;
    }
       public IActionResult Soma()
    {
        return View();
    }

    public IActionResult SomaResult([FromForm] double num1, [FromForm] double num2)
    {
        ViewData["num1"] = num1;
        ViewData["num2"] = num2;

        ViewData["result"] = num1 + num2;

        return View();
    }
    public IActionResult Subtracao()
    {
        return View();
    }

    public IActionResult SubtracaoResult([FromForm] double num1, [FromForm] double num2)
    {
        ViewData["num1"] = num1;
        ViewData["num2"] = num2;

        ViewData["result"] = num1 - num2;

        return View();
    }

        public IActionResult Divisao()
    {
        return View();
    }

    public IActionResult DivisaoResult([FromForm] double num1, [FromForm] double num2)
    {
        ViewData["num1"] = num1;
        ViewData["num2"] = num2;

        ViewData["result"] = (num1 / num2);

        return View();
    }

     public IActionResult Mult()
    {
        return View();
    }

    public IActionResult MultResult([FromForm] double num1, [FromForm] double num2)
    {
        ViewData["num1"] = num1;
        ViewData["num2"] = num2;
        ViewData["result"] = (num1 * num2);

        return View();
    }

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(){
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}