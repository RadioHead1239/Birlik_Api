using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Evento
    {
        [Key]
        public int Id_Evento { get; set; }

        public DateTime FechaInicioEvento { get; set; }

        public DateTime FechaFinEvento { get; set; }

        public string DescripcionEvento { get; set; }

        public string EstadoEvento { get; set; } //Visto - No Visto

        public string Usuario { get; set; }

        public string? ArchivoEvento { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ArchivoEvento_File { get; set; }

        public string NombreEvento { get; set; }

        public int TrazabilidadEvento { get; set; }

        public string TipoEvento { get; set; }

        public string? Requerimientos { get; set; }

        public string? Recompensas { get; set; }
    }
}
