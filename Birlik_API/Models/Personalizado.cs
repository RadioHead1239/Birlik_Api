using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Personalizado
    {
        [Key]
        public int Id_Personalizado { get; set; }

        public string TipoPersonalizado { get; set; }

        public string ImagenMensaje { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile ImagenMensajeFile { get; set; }

        public string CuerpoMensaje { get; set; }

        public string AsuntoMensaje { get; set; }

        public DateTime FechaRegistro { get; set; }


    }
}
