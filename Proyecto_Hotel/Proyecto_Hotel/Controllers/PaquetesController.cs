using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Hotel.Controllers
{
    public class PaquetesController : Controller
    {

        public int comprobarFuncionamiento  { get; set; }
        public IActionResult Index()
        {
            return View();
        }
    }
}
