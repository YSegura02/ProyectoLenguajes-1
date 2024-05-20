using System.ComponentModel.DataAnnotations;

namespace Proyecto_Hotel.Models
{
    //datos de la api
    public class Fisica
    {
        public string guess_type_num { get; set; }
        public string type { get; set; }
        public string guess_type { get; set; }
        public string rawcedula { get; set; }
        public List<Result> results { get; set; }
        public string fullname { get; set; }
        public string admin { get; set; }
        public string temp { get; set; }
        public string lastname { get; set; }
        public string firstname2 { get; set; }

        public string lastname1 { get; set; }
        public string lastname2 { get; set; }

        public string firstname1 { get; set; }

        [Key]
        public string cedula { get; set; }
        public string firstname { get; set; }




    }//fin de la clase cedula

}//
