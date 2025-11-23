
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class MensajeEnviado
    {

        [Key]
        public int Id_MensajeEnviado { get; set; }

        public string GeneradoMensajeEnviado { get; set; } //NATURAL - JURIDICO

        public string DescripcionMensajeEnviado { get; set; } // Razon Social - Nombres y Apellidos

        public string AsuntoMensajeEnviado { get; set; } // DNI/CEDULA - RUC - CEX - PAS

        public string ParaMensajeEnviado { get; set; }

        public string CopiaMensajeEnviado { get; set; }

        public DateTime FechaRegistroMensajeEnviado { get; set; } //Cumpleaños o Aniversarios

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ImagenFile { get; set; }

        public string? ImagenMensaje { get; set; }

        public string EstadoMensaje { get; set; }

        public DateTime? FechaProgramada { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile Archivo1File { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile Archivo2File { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile Archivo3File { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile Archivo4File { get; set; }

        public string? Archivo1Mensaje { get; set; }

        public string? Archivo2Mensaje { get; set; }

        public string? Archivo3Mensaje { get; set; }

        public string? Archivo4Mensaje { get; set; }


        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoVisualizarFile { get; set; }

        public string? ArchivoVisualizar { get; set; }

        public int Fk_Cliente { get; set; }

    }
}
