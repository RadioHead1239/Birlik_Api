using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class DetalleEvento
    {
        [Key]
        public int Id_DetalleEvento { get; set; }

        public DateTime? FechaConfirmacion { get; set; }

        public string Fk_Usuario { get; set; }

        public int Fk_Evento { get; set; } 

        public string? RespuestaEvento {  get; set; }

    }
}
