using System.ComponentModel.DataAnnotations;

namespace ProyectoHotel_1.Models
{
    public class Paquete
    {


        [Required(ErrorMessage = "Debe seleccionar el tipo del paquete")]
        //tipo del paquete 
        //todo incluido, alimentacion, hospedaje
        public string  tipoPaquete { get; set; }
        [Required(ErrorMessage = "Debe seleccionar la prima")]
        //el adelando que hay que dar
        public  decimal prima { get; set; }

        //el tiempo en el cual debe cubrirse
        public int tiempo { get; set; }

        //el monto total del paquete 
        public decimal montoTotal { get; set; }

    }
}
