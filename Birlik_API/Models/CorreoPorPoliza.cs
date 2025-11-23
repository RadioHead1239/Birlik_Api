using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class CorreoPorPoliza
    {

        [Key]
        public int Id_CorreoPoliza { get; set; }

        public string? EmailAdicional { get; set; }

        public int Fk_Poliza { get; set; }

        public string TipoCorreoPorPoliza { get; set; } 

    }
}
