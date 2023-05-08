using Microsoft.AspNetCore.Mvc;
using Mvc.Models;

namespace Mvc.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Responder()
    {
        return View();
    }
    
    
    
    [HttpPost]
    public IActionResult Responder(Resposta resposta)
    {
        // modo de validacao 
        if (ModelState.IsValid)
        {
            Repositorio.AdicionarResposta(resposta);
            return View("Obrigado");   
        }
        else
        {
            return View(resposta);
        }
        
    }

    public IActionResult Resultado()
    {
        return View(Repositorio.Respostas);
    }
    
}