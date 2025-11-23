using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class Documento
    {
        [Key]
        public int Id_Documento { get; set; }

        [Required(ErrorMessage = "Agrega un titulo para el documento")]
        public string TituloDocumento { get; set; }

        public string RutaDocumento { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int Fk_Poliza { get; set; }

        [NotMapped] // No es una columna en la base de datos
        [DisplayName("Upload File")]
        public List<IFormFile> DocumentoFiles { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload FilePDF")]
        public IFormFile DocumentoFile_PDF { get; set; }

    }
}
