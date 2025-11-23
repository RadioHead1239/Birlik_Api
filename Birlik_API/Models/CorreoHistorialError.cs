using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class CorreoHistorialError
    {
        [Key]
        public int Id_CorreoHistorialError { get; set; }

        public string? Destinatario { get; set; }

        public DateTime FechaRegistro { get; set; }

        public int Fk_CorreoHistorial { get; set; }

        public string? Error { get; set; }


    }
}
