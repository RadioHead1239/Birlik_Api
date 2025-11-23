using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Birlik.Models.Entities
{
    public class ClienteXAgente
    {
        [Key]
        public int Id_ClienteXAgente { get; set; }

        public string TipoPersona { get; set; }

        public string NombreClienteXAgente { get; set; }

        public string TipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string? Celular1 { get; set; }

        public string? Email1 { get; set; }

        public string? Contacto1 { get; set; }

        public string? Celular2 { get; set; }

        public string? Email2 { get; set; }

        public string? Contacto2 { get; set; }

        
        public string? DescripcionClienteXAgente { get; set; }


        public string? CelularClienteXAgente { get; set; }

        public string? EmailClienteXAgente { get; set; }

        public DateTime FechaClienteXAgente { get; set; }

        public string Fk_usuario { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoClienteXAgenteFile1 { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoClienteXAgenteFile2 { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoClienteXAgenteFile3 { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ArchivoClienteXAgenteFile4 { get; set; }

        public string? ArchivoClienteXAgente1 { get; set; }

        public string? ArchivoClienteXAgente2 { get; set; }

        public string? ArchivoClienteXAgente3 { get; set; }

        public string? ArchivoClienteXAgente4 { get; set; }


    }
}
