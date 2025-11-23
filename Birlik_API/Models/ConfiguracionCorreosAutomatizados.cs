using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class ConfiguracionCorreosAutomatizados
    {
        [Key]
        public int Id_ConfiguracionCorreosAutomatizados { get; set; }

        public string TipoCorreo { get; set; }

        public string NombreAmigable { get; set; }

        public string Descripcion { get; set; }

        public string Activo { get; set; }

        public DateTime HoraEjecucion { get; set; }

        public int DiasAnticipacion { get; set; }

        public string FrecuenciaEjecucion { get; set; }

        public string ImagenCabecera { get; set; }

        public string CorreosCopiaFijos { get; set; }

        public string Destinatario { get; set; }

        public string De { get; set; }

        public string Prioridad { get; set; }

        public DateTime? UltimaEjecucion { get; set; }

        public DateTime? ProximaEjecucion { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public int Fk_Cliente { get; set; }

        public int Fk_Cuota { get; set; }

        public int Fk_Poliza { get; set; }

    }
}
