using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Historial_CartaNombramiento
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_CartaNombramiento { get; set; }
        public string Fk_Usuario { get; set; }
        public int Fk_Cliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UrlArchivo { get; set; }



    }
}
