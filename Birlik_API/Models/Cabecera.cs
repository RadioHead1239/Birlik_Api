using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Cabecera
    {
        [Key]
        public int Id_Cabecera { get; set; }

        public string Imagen { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ImagenFile { get; set; }

        public string? AreaUso { get; set; }

        public string? ControladorUso { get; set; }

        public string? ActionUso { get; set; }

    }
}
