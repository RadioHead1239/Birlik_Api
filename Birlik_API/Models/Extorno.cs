using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Extorno
    {

        [Key]
        public int Id_Extorno { get; set; }

        public decimal MontoExtornado { get; set; }

        public int Fk_Poliza { get; set; }

        public int Fk_Cliente { get; set; }

        public int Fk_SeguroDetalle { get; set; }

        [DataType(DataType.Date)]
        public DateTime VigenciaExtorno { get; set; }

        public DateTime FechaRegistroExtorno { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile NotaDecrito_File { get; set; }

        public string NotaDecrito { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile CartaDevolucion_File { get; set; }

        public string? CartaDevolucion { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile CartaModeloExclusion_File { get; set; }

        public string? CartaModeloExclusion { get; set; }

        public string? ComentarioExtorno { get; set; }

        public string Fk_usuario { get; set; }

    }
}
