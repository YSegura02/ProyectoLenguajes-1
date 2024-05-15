using System.ComponentModel.DataAnnotations;

namespace Proyecto_Hotel.Models
{
    public class Cliente
    {
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

    }
}
