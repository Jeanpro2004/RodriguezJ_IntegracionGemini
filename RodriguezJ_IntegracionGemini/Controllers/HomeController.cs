using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RodriguezJ_IntegracionGemini.Models;
using RodriguezJ_IntegracionGemini.Repositories;

namespace RodriguezJ_IntegracionGemini.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task <IActionResult> Index()
    {
        GeminiRepository repo = new GeminiRepository();
        string response = await repo.GetChatbotResponseAsync("Hola, ¿cómo estás?");
        ViewBag.chatbotAnswer = response;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
