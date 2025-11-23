using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class PuntuacionUsuario
    {
        [Key]
        public int Id_PuntuacionUsuario { get; set; }

        public DateTime FechaCreacion { get; set; }

        public string Motivo { get; set; }

        public string CantidadPuntos { get; set; }

        public int Fk_Usuario { get; set; }



    }
}
