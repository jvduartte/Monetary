using Financial_Monetary_Vision.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Financial_Monetary_Vision.Controllers
{
    public class ServicosController : Controller
    {
        private readonly ILogger<ServicosController> _logger;

        public ServicosController(ILogger<ServicosController> logger)
        {
            _logger = logger;
        }



        public IActionResult Index()
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
