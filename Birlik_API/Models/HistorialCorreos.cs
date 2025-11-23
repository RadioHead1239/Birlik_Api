using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class HistorialCorreos
    {
        [Key]
        public int Id { get; set; } // Primary Key
        public string IdMicrosoftGraph { get; set; }
        public string CorreoEjecutivo { get; set; }
        public string CorreoRemitente { get; set; }

        public string CorreoDestinatario { get; set; }
        public string Asunto { get; set; }
        public DateTime FechaRecibido { get; set; }
        public string CuerpoMensaje { get; set; }
        public string Sentimiento { get; set; }
        public double Positive { get; set; }
        public double Neutral { get; set; }
        public double Negative { get; set; }
        public string Resumen { get; set; }
        public string FrasesClave { get; set; }

        public string TipoBandeja { get; set; }


    }
}
