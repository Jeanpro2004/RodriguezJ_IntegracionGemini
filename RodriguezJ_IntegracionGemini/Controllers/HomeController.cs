using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RodriguezJ_IntegracionGemini.Interfaces;
using RodriguezJ_IntegracionGemini.Models;
using RodriguezJ_IntegracionGemini.Repositories;

namespace RodriguezJ_IntegracionGemini.Controllers;

public class HomeController : Controller
{
    private IChatbotService _chatbotService;

    public HomeController(IChatbotService chatbotService)
    {
        _chatbotService = chatbotService;
       
    }

    public async Task <IActionResult> Index()
    {

        string response = await _chatbotService.GetChatbotResponseAsync("Hola,como estas?");
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
