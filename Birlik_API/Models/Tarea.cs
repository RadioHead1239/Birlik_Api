using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Tarea
    {
        [Key]
        public int Id_Tarea { get; set; }

        public string DescripcionTarea { get; set; }

        public DateTime? FechaSolicitud { get; set; }

        public string EstadoTarea { get; set; }

        public DateTime FechaRegistroTarea { get; set; }

        public DateTime? FechaRespuesta { get; set; }

        public string Fk_Usuario { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime FechaVencimiento { get; set; }

        public string Usuario { get; set; }

        public string? Respuesta { get; set; }

        public string? ArchivoTarea { get; set; }
        public string? ArchivoTarea2 { get; set; }
        public string? ArchivoTarea3 { get; set; }
        public string? ArchivoTarea4 { get; set; }

        public string? ArchivoTarea5 { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ArchivoTarea_File { get; set; }

        [NotMapped]
        [DisplayName("Archivos adicionales")]
        public List<IFormFile> ArchivoTarea_Lista { get; set; }

        public string? ArchivoTarea1 { get; set; }

        public string? EjecutivoApoyo { get; set; }

    }
}
