using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Organizacion
    {

        [Key]
        public int Id_Organizacion { get; set; }

        public string Nom_Organizacion { get; set; }

        public string MetodoTrabajo { get; set; }

        public string CorreoCobranza { get; set; }

        public string Direccion { get; set; }

        public string Num_Telefonico { get; set; }

        public string Img_Organizacion { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ImagenFile { get; set; }

        public DateTime Fecha_Inscripcion { get; set; }

        public string CorreosCopia { get; set; }

    }
}
