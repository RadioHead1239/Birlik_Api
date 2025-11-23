using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class Solicitud // Solicitud para gestionar los TICKETS
    {
        [Key]
        public int Id_Solicitud { get; set; }

        public DateTime FechaSolicitud { get; set; }

        public string TipoSolicitud { get; set; } // Editar Prima minima - Editar cliente - Editar poliza

        public string DescripcionSolicitud { get; set; }

        public string EstadoSolicitud { get; set; } //Aprobado - Pendiente - Denegado

        public string Usuario { get; set; }

        public string Fk_Usuario { get; set; }

        public int Fk_Cliente { get; set; }

        public int Fk_Poliza { get; set; }


    }
}
