using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Mensaje
    {
        [Key]
        public int Id_Mensaje { get; set; }

        public DateTime FechaMensaje { get; set; }

        public DateTime FechaLeido { get; set; }

        public string DescripcionMensaje { get; set; }

        public string EstadoMensaje { get; set; } //Visto - No Visto

        public string Usuario { get; set; }

        public string Fk_Usuario { get; set; }

        public string? ArchivoInformativo { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ArchivoInformativo_File { get; set; }

        public string NombreMensaje { get; set; }

        public int TrazabilidadMensaje { get; set; }
    }
}
