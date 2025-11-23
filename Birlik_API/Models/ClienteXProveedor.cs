using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Birlik.Models.Entities
{
    public class ClienteXProveedor
    {
        [Key]
        public int Id_ClienteXProveedor { get; set; }

        public string TipoPersona { get; set; }

        public string NombreClienteXProveedor { get; set; }

        public string TipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string? Celular1 { get; set; }

        public string? Email1 { get; set; }

        public string? Contacto1 { get; set; }

        public string? Celular2 { get; set; }

        public string? Email2 { get; set; }

        public string? Contacto2 { get; set; }

        public string? CelularClienteXProveedor { get; set; }

        public string? EmailClienteXProveedor { get; set; }

        public DateTime FechaClienteXProveedor { get; set; }

        public string Fk_usuario { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoClienteXProveedorFile1 { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoClienteXProveedorFile2 { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoClienteXProveedorFile3 { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoClienteXProveedorFile4 { get; set; }

        public string? ArchivoClienteXProveedor1 { get; set; }

        public string? ArchivoClienteXProveedor2 { get; set; }

        public string? ArchivoClienteXProveedor3 { get; set; }

        public string? ArchivoClienteXProveedor4 { get; set; }


    }
}
