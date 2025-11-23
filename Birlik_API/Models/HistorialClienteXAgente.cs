using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class HistorialClienteXAgente
    {
        [Key]
        public int Id_HistorialClienteXAgente { get; set; }

        public string DescripcionHistorialClienteXAgente { get; set; }

        public DateTime FechaHistorialClienteXAgente { get; set; }

        public string Fk_usuario { get; set; }

        public int Fk_ClienteXAgente { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoHistorialClienteXAgenteFile1 { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoHistorialClienteXAgenteFile2 { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoHistorialClienteXAgenteFile3 { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoHistorialClienteXAgenteFile4 { get; set; }

        public string? ArchivoHistorialClienteXAgente1 { get; set; }

        public string? ArchivoHistorialClienteXAgente2 { get; set; }

        public string? ArchivoHistorialClienteXAgente3 { get; set; }

        public string? ArchivoHistorialClienteXAgente4 { get; set; }

        public string TipoHistorialClienteXAgente { get; set; }

    }
}
