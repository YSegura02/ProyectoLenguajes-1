using Microsoft.AspNetCore.Mvc;

namespace ProyectoHotel_1.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
