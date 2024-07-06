using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TODO.Web.Models;
using TODO.Web.Services;

namespace TODO.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TodoListService _todoListService;

        public HomeController(ILogger<HomeController> logger, TodoListService todoListService)
        {
            _logger = logger;
            _todoListService = todoListService;
        }

        public async Task<IActionResult> Index()
        {
            var todoLists = await _todoListService.GetAllAsync();

            return View(todoLists);
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
}
