using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Registro
    {
        [Key]
        public int Id_Registro { get; set; }

        public string TipoRegistro { get; set; }

        public string DescripcionRegistro { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int Fk_Cliente { get; set; }

        public int Fk_Poliza { get; set; }

        public int Fk_Cuota { get; set; }

        public string Fk_Usuario { get; set; }

        public string Estado { get; set; }

        [NotMapped]
        public string NombreUsuario { get; set; }

        [NotMapped]
        public string Imagen { get; set; }

    }
}
