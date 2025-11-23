using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class Ramo
    {
        [Key]
        public int Id_Ramo { get; set; }

        public string DescripcionRamo { get; set; }

        public string DescripcionCortoRamo { get; set; }

        public string EstadoRamo { get; set; } 
    }
}
