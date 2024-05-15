using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Hotel.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
