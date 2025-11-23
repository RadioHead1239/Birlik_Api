using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class FirmaElectronica
    {
        [Key]
        public int idFirma { get; set; }

        public string observacion { get; set; }

        public string fkUsuario { get; set; }

        public DateTime fechaRegistro { get; set; } 

        public string rol { get; set; }

        public int fkReporte { get; set; }

    }
}
