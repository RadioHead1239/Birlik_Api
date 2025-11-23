using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class GiroNegocio
    {
        [Key]
        public int Id_GiroNegocio { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string DescripcionGiroNegocio { get; set; }

        public string CodigoGiro { get; set; }

        public string EstadoGiro { get; set; }
    }
}
