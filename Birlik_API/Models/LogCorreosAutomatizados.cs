using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class LogCorreosAutomatizados
    {
        [Key]
        public int Id_LogCorreosAutomatizados { get; set; }

        public string TipoCorreo { get; set; }

        public string CategoriaCorreo { get; set; }

        public DateTime? FechaHoraProgramada { get; set; }

        public DateTime FechaHoraEnvio { get; set; }

        public string DestinarioCorreo { get; set; }

        public string CopiasCorreo { get; set; }

        public string AsuntoCorreo { get; set; }

        public string ImagenCabecera { get; set; }

        public string EstadoEnvio { get; set; }

        public string MensajeError { get; set; }

        public string CodigoErrorAPI { get; set; }

        public string Fk_Usuario { get; set; }

        public int Fk_Cliente { get; set; }

        public int Fk_Poliza { get; set; }

        public int Fk_Cuota { get; set; }

        public int Fk_Tarea { get; set; }

        public int Fk_GPS { get; set; }

        public string MetadatosJSON { get; set; }

        public int DuracionEnvioMs { get; set; }

        public int IntentosRealizados { get; set; }

        public string CreadoPor { get; set; }

        public DateTime FechaCreacion { get; set; }

    }
}
