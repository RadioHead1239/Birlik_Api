using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class EstadoPuntuacion
    {
        [Key]
        public int IdEstadoPuntuacion { get; set; }

        public string Nombre { get; set; }

        public int Minimo { get; set; }

        public int Maximo { get; set; }

        public string Descripcion { get; set; }

        public string Color { get; set; }

    }
}
