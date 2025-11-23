using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class Notificacion
    {
        [Key]
        public int Id_Notificacion { get; set; }

        public DateTime FechaNotificacion { get; set; }

        public string TipoNotificacion { get; set; } // Registro - Actualizacion - Solicitud

        public string DescripcionNotificacion { get; set; }

        public string Usuario { get; set; }

        public string Fk_Usuario { get; set; }


    }
}
