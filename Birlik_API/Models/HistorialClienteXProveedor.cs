using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class HistorialClienteXProveedor
    {
        [Key]
        public int Id_HistorialClienteXProveedor { get; set; }

        public string DescripcionHistorialClienteXProveedor { get; set; }

        public DateTime FechaHistorialClienteXProveedor { get; set; }

        public string Fk_usuario { get; set; }

        public int Fk_ClienteXProveedor { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoHistorialClienteXProveedorFile1 { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoHistorialClienteXProveedorFile2 { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoHistorialClienteXProveedorFile3 { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoHistorialClienteXProveedorFile4 { get; set; }

        public string? ArchivoHistorialClienteXProveedor1 { get; set; }

        public string? ArchivoHistorialClienteXProveedor2 { get; set; }

        public string? ArchivoHistorialClienteXProveedor3 { get; set; }

        public string? ArchivoHistorialClienteXProveedor4 { get; set; }

        public string TipoHistorialClienteXProveedor { get; set; }

    }
}
