using System.ComponentModel.DataAnnotations;

namespace Proyecto_Hotel.Models
{
    public class Cliente
    {
        CedulaAPI api;

        public static Fisica cedulaFisica = null;
        [Key]
        public int Cedula { get; set; }

        [Required(ErrorMessage = "Seleccione el tipo de cédula")]
        [DataType(DataType.Text)]
        [StringLength(70)]
        public string TipoCedula { get; set; }

        [Required(ErrorMessage = "Escriba su nombre completo.")]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "Seleccione el tipo de cédula")]
        [Range(0, Int64.MaxValue)]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "Escriba su dirección.")]
        [DataType(DataType.Text)]
        [StringLength(150)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Escriba su dirección.")]
        [DataType(DataType.EmailAddress)]
        [StringLength(150)]
        public string email { get; set; }

        public int Rol { get; set; }

        //public string idGometa
        //{
        //    //no se sabe si esta correcto por el tipo de dato
        //    get
        //    {
        //        return (Proyecto_Hotel.Controllers.HomeController.datos.cedula.ToString());
        //    }
        //}



       

        //public void ObtenerInformacionPersona()
        //{
        //    // Llamada al método Iniciar para obtener una instancia de HttpClient configurada
        //    var cliente = api.Iniciar();


        //    // Construir la URL completa concatenando el ID de la persona al final de la URL base
        //    string url = $"https://apis.gometa.org/cedulas/{Cedula}";

        //    // Realizar la solicitud GET al servicio web
        //    HttpResponseMessage respuesta = cliente.GetAsync(url).Result;

        //    // Asegúrate de manejar la respuesta adecuadamente
        //    if (respuesta.IsSuccessStatusCode)
        //    {
        //        // Procesar la respuesta si es exitosa
        //        string contenido = respuesta.Content.ReadAsStringAsync().Result;
        //        Console.WriteLine(contenido);
        //    }
        //    else
        //    {
        //        // Manejar errores si la llamada no fue exitosa
        //        Console.WriteLine("La solicitud no fue exitosa. Código de estado: " + respuesta.StatusCode);
        //    }

        //}//fin del metodo 


        //-----------------------------------------------------------------------------------------------------
    }
}
