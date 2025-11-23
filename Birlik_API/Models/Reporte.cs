using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Reporte
    {
        [Key]
        public int idReporte { get; set; }

        public string fkUsuario { get; set; }


        public string json { get; set; }


        public DateTime fechaRegistro { get; set; }

        public string estado { get; set; }

        public DateTime? fechaReunion { get; set; }

        [NotMapped]
        public string nombreUsuario { get; set; }

        [NotMapped]
        public string imgUsuario { get; set; }

        public string estadoReunion { get; set; }

    }
}
