using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class CorreoHistorial
    {
        [Key]
        public int Id_CorreoHistorial { get; set; }

        public string Asunto { get; set; }

        public string? DestinatariosExito { get; set; }

        public string? DestinatariosError { get; set; }

        public string? Cuerpo { get; set; }

        public DateTime FechaEnvio { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string? Estado { get; set; }

        public string? Error { get; set; }
    }
}
