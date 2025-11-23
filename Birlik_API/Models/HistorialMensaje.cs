using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class HistorialMensaje
    {

        [Key]
        public int Id_HistorialMensaje { get; set; }

        public string TipoHistorialMensaje { get; set; }

        public DateTime FechaRegistroHistorialMensaje { get; set; }

        public int Fk_Cliente { get; set; }

        public string Usuario { get; set; }

        public int Fk_MensajeEnviado { get; set; }

        public int Fk_DetalleUsuario { get; set; }

        public int Fk_Poliza { get; set; }

        public int Fk_Cuota { get; set; }

    }
}
