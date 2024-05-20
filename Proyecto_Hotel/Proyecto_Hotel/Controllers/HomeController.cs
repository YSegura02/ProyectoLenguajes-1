using Microsoft.AspNetCore.Mvc;
using Proyecto_Hotel.Models;
using System.Diagnostics;
using Newtonsoft.Json;

namespace Proyecto_Hotel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private CedulaAPI cedulaApi = null;
        private HttpClient clientCedula = null;
        public static Fisica datos = null;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            cedulaApi= new CedulaAPI();
            clientCedula = cedulaApi.Iniciar();

        }

        public IActionResult Index()
        {
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

        Cliente clien = new Cliente();

        
        //------------------------------------------------------------------------


        public async void ExtraerCedula()
        {
            try
            {
                HttpResponseMessage response = await clientCedula.GetAsync(clien.Cedula.ToString());
                
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    datos = JsonConvert.DeserializeObject<Fisica>(result);

                }

            }
            catch (Exception ex)
            {

                throw ex;

            }

        }//FIN DEL METODO EXTRAER CEDULA 


    }
}
