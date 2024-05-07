using Microsoft.AspNetCore.Mvc;

namespace ProyectoHotel_1.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
