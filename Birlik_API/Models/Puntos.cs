using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Puntos
    {
        [Key]
        public int Id_Puntos { get; set; }

        public string DescripcionPuntos { get; set; }


        public int Valor { get; set; }


        public string Fk_Usuario { get; set; }


        public DateTime FechaRegistroPuntos { get; set; }


        public string EjecutivoAsignado { get; set; }

        public string Accion { get; set; }

        [NotMapped]
        public string AsignadoPor { get; set; }

        public int Fk_Tarea { get; set; }

        public string TipoPunto { get; set; } // Tarea y Ticket

        public string EstadoPunto { get; set; } // Otorgado y No-otorgado



    }
}
