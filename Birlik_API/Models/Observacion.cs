using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class Observacion
    {

        [Key]
        public int Id_Observacion { get; set; }

        public string Categoria { get; set; }

        public string Comentario { get; set; }

        public string Tipo { get; set; }

        public string Fk_Usuario { get; set; }

        public int Fk_Global { get; set; }

        public DateTime FechaObservacion { get; set; }

    }
}
